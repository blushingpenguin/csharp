using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using k8s.Models;
using Microsoft.Rest.Serialization;

namespace k8s
{
    /// <summary>Describes the type of a watch event.</summary>
    public enum WatchEventType
    {
        /// <summary>Emitted when an object is created, modified to match a watch's filter, or when a watch is first opened.</summary>
        [EnumMember(Value = "ADDED")]
        Added,

        /// <summary>Emitted when an object is modified.</summary>
        [EnumMember(Value = "MODIFIED")]
        Modified,

        /// <summary>Emitted when an object is deleted or modified to no longer match a watch's filter.</summary>
        [EnumMember(Value = "DELETED")]
        Deleted,

        /// <summary>Emitted when an error occurs while watching resources. Most commonly, the error is 410 Gone which indicates that
        /// the watch resource version was outdated and events were probably lost. In that case, the watch should be restarted.
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error,

        /// <summary>Bookmarks may be emitted periodically to update the resource version. The object will
        /// contain only the resource version.
        /// </summary>
        [EnumMember(Value = "BOOKMARK")]
        Bookmark,
    }

    public class Watcher<T> : IDisposable
    {
        /// <summary>
        /// indicate if the watch object is alive
        /// </summary>
        public bool Watching { get; private set; }

        private readonly CancellationTokenSource _cts;
        private bool disposedValue;
        private readonly Task _watcherLoop;

        /// <summary>
        /// Initializes a new instance of the <see cref="Watcher{T}"/> class.
        /// </summary>
        /// <param name="streamReaderCreator">
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
                    _cts.Token);
            });
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
                using var streamReader = await streamReaderCreator().ConfigureAwait(false);
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
                            SafeJsonConvert.DeserializeObject<Watcher<KubernetesObject>.WatchEvent>(line);

                        if (genericEvent.Object.Kind == "Status")
                        {
                            var statusEvent = SafeJsonConvert.DeserializeObject<Watcher<V1Status>.WatchEvent>(line);
                            if (onError != null)
                            {
                                var exception = new KubernetesException(statusEvent.Object);
                                await onError(cancellationToken, exception).ConfigureAwait(false);
                            }
                        }
                        else
                        {
                            var @event = SafeJsonConvert.DeserializeObject<WatchEvent>(line);
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

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _cts?.Cancel();
                    _cts?.Dispose();
                }

                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Watcher()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
