using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using k8s.Exceptions;
using k8s.Models;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;

namespace k8s
{
    /// <summary>Describes the type of a watch event.</summary>
    public enum WatchEventType
    {
        /// <summary>Emitted when an object is created, modified to match a watch's filter, or when a watch is first opened.</summary>
        [EnumMember(Value = "ADDED")] Added,

        /// <summary>Emitted when an object is modified.</summary>
        [EnumMember(Value = "MODIFIED")] Modified,

        /// <summary>Emitted when an object is deleted or modified to no longer match a watch's filter.</summary>
        [EnumMember(Value = "DELETED")] Deleted,

        /// <summary>Emitted when an error occurs while watching resources. Most commonly, the error is 410 Gone which indicates that
        /// the watch resource version was outdated and events were probably lost. In that case, the watch should be restarted.
        /// </summary>
        [EnumMember(Value = "ERROR")] Error,

        /// <summary>Bookmarks may be emitted periodically to update the resource version. The object will
        /// contain only the resource version.
        /// </summary>
        [EnumMember(Value = "BOOKMARK")] Bookmark,
    }

    public class Watcher<T> : IDisposable
    {
        /// <summary>
        /// indicate if the watch object is alive
        /// </summary>
        public bool Watching { get; private set; }

        private readonly CancellationTokenSource _cts;
        private readonly Task _watcherLoop;

        /// <summary>
        /// Initializes a new instance of the <see cref="Watcher{T}"/> class.
        /// </summary>
        /// <param name="streamReader">
        /// A <see cref="StreamReader"/> from which to read the events.
        /// </param>
        /// <param name="onEvent">
        /// The action to invoke when the server sends a new event.
        /// </param>
        /// <param name="onError">
        /// The action to invoke when an error occurs.
        /// </param>
        /// <param name="onClosed">
        /// The action to invoke when the server closes the connection.
        /// </param>
        public Watcher(Func<Task<IAsyncLineReader>> streamReaderCreator, Action<WatchEventType, T> onEvent,
            Action<Exception> onError, Action onClosed = null)
        {
            OnEvent += onEvent;
            OnError += onError;
            OnClosed += onClosed;

            _cts = new CancellationTokenSource();
            _watcherLoop = Task.Run(() =>
            {
                Watching = true;
                return WatchAsync(
                    streamReaderCreator,
                    (_, evtType, evt) =>
                    {
                        OnEvent?.Invoke(evtType, evt);
                        return Task.FromResult(true);
                    },
                    (_, exception) =>
                    {
                        OnError?.Invoke(exception);
                        return Task.FromResult(true);
                    },
                    _ =>
                    {
                        Watching = false;
                        OnClosed?.Invoke();
                        return Task.FromResult(true);
                    },
                    _cts.Token
                );
            });
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _cts.Cancel();
        }

        /// <summary>
        /// add/remove callbacks when any event raised from api server
        /// </summary>
        public event Action<WatchEventType, T> OnEvent;

        /// <summary>
        /// add/remove callbacks when any exception was caught during watching
        /// </summary>
        public event Action<Exception> OnError;

        /// <summary>
        /// The event which is raised when the server closes th econnection.
        /// </summary>
        public event Action OnClosed;

        public class WatchEvent
        {
            public WatchEventType Type { get; set; }

            public T Object { get; set; }
        }

        internal static async Task WatchAsync(
            Func<Task<IAsyncLineReader>> streamReaderCreator,
            Func<CancellationToken, WatchEventType, T, Task> onEvent,
            Func<CancellationToken, Exception, Task> onError = null,
            Func<CancellationToken, Task> onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var streamReader = await streamReaderCreator().ConfigureAwait(false);
                string line;
                // ReadLineAsync will return null when we've reached the end of the stream.
                while ((line = await streamReader.ReadLineAsync(cancellationToken).ConfigureAwait(false)) != null)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

                    try
                    {
                        var genericEvent =
                            SafeJsonConvert.DeserializeObject<k8s.Watcher<KubernetesObject>.WatchEvent>(line);

                        if (genericEvent.Object.Kind == "Status")
                        {
                            var statusEvent = SafeJsonConvert.DeserializeObject<k8s.Watcher<V1Status>.WatchEvent>(line);
                            if (onError != null)
                            {
                                var exception = new KubernetesException(statusEvent.Object);
                                await onError(cancellationToken, exception).ConfigureAwait(false);
                            }
                        }
                        else
                        {
                            var @event = SafeJsonConvert.DeserializeObject<k8s.Watcher<T>.WatchEvent>(line);
                            if (onEvent != null)
                            {
                                await onEvent(cancellationToken, @event.Type, @event.Object).ConfigureAwait(false);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // error if deserialized failed or onevent throws
                        if (onError != null)
                        {
                            await onError(cancellationToken, e).ConfigureAwait(false);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // error when transport error, IOException ect
                if (onError != null)
                {
                    await onError(cancellationToken, e).ConfigureAwait(false);
                }
            }
            finally
            {
                if (onClosed != null)
                {
                    await onClosed(cancellationToken).ConfigureAwait(false);
                }
            }
        }
    }

    public static class WatcherExt
    {
        private static async Task<IAsyncLineReader> CreateStreamReaderAsync<L>(
            Task<HttpOperationResponse<L>> responseTask
        )
        {
            var response = await responseTask.ConfigureAwait(false);

            if (!(response.Response.Content is ILineSeparatedHttpContent content))
            {
                throw new KubernetesClientException("not a watchable request or failed response");
            }

            return content.StreamReader;
        }

        /// <summary>
        /// create a watch object from a call to api server with watch=true
        /// </summary>
        /// <typeparam name="T">type of the event object</typeparam>
        /// <typeparam name="L">type of the HttpOperationResponse object</typeparam>
        /// <param name="response">the api response</param>
        /// <param name="onEvent">a callback when any event raised from api server</param>
        /// <param name="onError">a callbak when any exception was caught during watching</param>
        /// <param name="onClosed">
        /// The action to invoke when the server closes the connection.
        /// </param>
        /// <returns>a watch object</returns>
        public static Watcher<T> Watch<T, L>(this Task<HttpOperationResponse<L>> responseTask,
            Action<WatchEventType, T> onEvent,
            Action<Exception> onError = null,
            Action onClosed = null)
        {
            return new Watcher<T>(() => CreateStreamReaderAsync(responseTask), onEvent, onError, onClosed);
        }

        /// <summary>
        /// create a watch object from a call to api server with watch=true
        /// </summary>
        /// <typeparam name="T">type of the event object</typeparam>
        /// <typeparam name="L">type of the HttpOperationResponse object</typeparam>
        /// <param name="response">the api response</param>
        /// <param name="onEvent">a callback when any event raised from api server</param>
        /// <param name="onError">a callbak when any exception was caught during watching</param>
        /// <param name="onClosed">
        /// The action to invoke when the server closes the connection.
        /// </param>
        /// <returns>a watch object</returns>
        public static Watcher<T> Watch<T, L>(this HttpOperationResponse<L> response,
            Action<WatchEventType, T> onEvent,
            Action<Exception> onError = null,
            Action onClosed = null)
        {
            return Watch(Task.FromResult(response), onEvent, onError, onClosed);
        }

        /// <summary>
        /// watch the call to api server with watch=true asynchronously
        /// </summary>
        /// <typeparam name="T">type of the event object</typeparam>
        /// <typeparam name="L">type of the HttpOperationResponse object</typeparam>
        /// <param name="response">the api response</param>
        /// <param name="onEvent">a callback when any event raised from api server</param>
        /// <param name="onError">a callbak when any exception was caught during watching</param>
        /// <param name="onClosed">
        /// The action to invoke when the server closes the connection.
        /// </param>
        /// <param name="cancellationToken">A token that can be used to cancel the watch</param>
        /// <returns>a watch object</returns>
        public static Task WatchAsync<T, L>(
            this Task<HttpOperationResponse<L>> response,
            Func<CancellationToken, WatchEventType, T, Task> onEvent,
            Func<CancellationToken, Exception, Task> onError = null,
            Func<CancellationToken, Task> onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return Watcher<T>.WatchAsync(() => CreateStreamReaderAsync(response), onEvent, onError, onClosed, cancellationToken);
        }

        /// <summary>
        /// watch the call to api server with watch=true asynchronously
        /// </summary>
        /// <typeparam name="T">type of the event object</typeparam>
        /// <param name="response">the api response</param>
        /// <param name="onEvent">a callback when any event raised from api server</param>
        /// <param name="onError">a callbak when any exception was caught during watching</param>
        /// <param name="onClosed">
        /// The action to invoke when the server closes the connection.
        /// </param>
        /// <param name="cancellationToken">A token that can be used to cancel the watch</param>
        /// <returns>a watch object</returns>
        public static Task WatchAsync<T, L>(
            this HttpOperationResponse<L> response,
            Func<CancellationToken, WatchEventType, T, Task> onEvent,
            Func<CancellationToken, Exception, Task> onError = null,
            Func<CancellationToken, Task> onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return WatchAsync(Task.FromResult(response), onEvent, onError, onClosed, cancellationToken);
        }
    }
}
