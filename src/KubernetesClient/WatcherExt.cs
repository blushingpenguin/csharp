using System;
using System.Threading;
using System.Threading.Tasks;
using k8s.Exceptions;
using Microsoft.Rest;

namespace k8s
{
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
        /// <param name="responseTask">the api response</param>
        /// <param name="onEvent">a callback when any event raised from api server</param>
        /// <param name="onError">a callbak when any exception was caught during watching</param>
        /// <param name="onClosed">
        /// The action to invoke when the server closes the connection.
        /// </param>
        /// <returns>a watch object</returns>
        public static Watcher<T> Watch<T, L>(
            this Task<HttpOperationResponse<L>> responseTask,
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
        public static Watcher<T> Watch<T, L>(
            this HttpOperationResponse<L> response,
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
