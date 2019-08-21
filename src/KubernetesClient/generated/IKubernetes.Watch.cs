using k8s.Models;
using System; 
using System.Collections.Generic; 
using System.Threading; 
using System.Threading.Tasks; 

namespace k8s
{
    public partial interface IKubernetes
    {
        /// <summary>
        /// list objects of kind ComponentStatus
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ComponentStatus>> WatchComponentStatusAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ComponentStatus> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ConfigMap
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ConfigMap>> WatchConfigMapForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ConfigMap> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Endpoints
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Endpoints>> WatchEndpointsForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Endpoints> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Event
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Event>> WatchEventForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Event> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind LimitRange
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1LimitRange>> WatchLimitRangeForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1LimitRange> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Namespace
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Namespace>> WatchNamespaceAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Namespace> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ConfigMap
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ConfigMap>> WatchNamespacedConfigMapAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ConfigMap> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Endpoints
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Endpoints>> WatchNamespacedEndpointsAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Endpoints> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Event
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Event>> WatchNamespacedEventAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Event> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind LimitRange
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1LimitRange>> WatchNamespacedLimitRangeAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1LimitRange> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PersistentVolumeClaim
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1PersistentVolumeClaim>> WatchNamespacedPersistentVolumeClaimAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1PersistentVolumeClaim> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Pod
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Pod>> WatchNamespacedPodAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Pod> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PodTemplate
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1PodTemplate>> WatchNamespacedPodTemplateAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1PodTemplate> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ReplicationController
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ReplicationController>> WatchNamespacedReplicationControllerAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ReplicationController> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ResourceQuota
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ResourceQuota>> WatchNamespacedResourceQuotaAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ResourceQuota> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Secret
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Secret>> WatchNamespacedSecretAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Secret> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ServiceAccount
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ServiceAccount>> WatchNamespacedServiceAccountAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ServiceAccount> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Service
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Service>> WatchNamespacedServiceAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Service> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Node
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Node>> WatchNodeAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Node> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PersistentVolumeClaim
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1PersistentVolumeClaim>> WatchPersistentVolumeClaimForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1PersistentVolumeClaim> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PersistentVolume
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1PersistentVolume>> WatchPersistentVolumeAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1PersistentVolume> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Pod
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Pod>> WatchPodForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Pod> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PodTemplate
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1PodTemplate>> WatchPodTemplateForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1PodTemplate> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ReplicationController
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ReplicationController>> WatchReplicationControllerForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ReplicationController> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ResourceQuota
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ResourceQuota>> WatchResourceQuotaForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ResourceQuota> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Secret
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Secret>> WatchSecretForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Secret> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ServiceAccount
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ServiceAccount>> WatchServiceAccountForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ServiceAccount> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Service
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Service>> WatchServiceForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Service> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind MutatingWebhookConfiguration
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1MutatingWebhookConfiguration>> WatchMutatingWebhookConfigurationAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1MutatingWebhookConfiguration> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ValidatingWebhookConfiguration
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1ValidatingWebhookConfiguration>> WatchValidatingWebhookConfigurationAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1ValidatingWebhookConfiguration> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CustomResourceDefinition
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1CustomResourceDefinition>> WatchCustomResourceDefinitionAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1CustomResourceDefinition> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind APIService
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1APIService>> WatchAPIServiceAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1APIService> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind APIService
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1APIService>> WatchAPIServiceAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1APIService> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ControllerRevision>> WatchControllerRevisionForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ControllerRevision> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1DaemonSet>> WatchDaemonSetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1DaemonSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Deployment
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Deployment>> WatchDeploymentForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Deployment> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ControllerRevision>> WatchNamespacedControllerRevisionAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ControllerRevision> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1DaemonSet>> WatchNamespacedDaemonSetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1DaemonSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Deployment
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Deployment>> WatchNamespacedDeploymentAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Deployment> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ReplicaSet>> WatchNamespacedReplicaSetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ReplicaSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1StatefulSet>> WatchNamespacedStatefulSetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1StatefulSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ReplicaSet>> WatchReplicaSetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ReplicaSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1StatefulSet>> WatchStatefulSetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1StatefulSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1ControllerRevision>> WatchControllerRevisionForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1ControllerRevision> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1ControllerRevision>> WatchNamespacedControllerRevisionAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1ControllerRevision> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1StatefulSet>> WatchNamespacedStatefulSetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1StatefulSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1StatefulSet>> WatchStatefulSetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1StatefulSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2ControllerRevision>> WatchControllerRevisionForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2ControllerRevision> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2DaemonSet>> WatchDaemonSetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2DaemonSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Deployment
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2Deployment>> WatchDeploymentForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2Deployment> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ControllerRevision
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2ControllerRevision>> WatchNamespacedControllerRevisionAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2ControllerRevision> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind DaemonSet
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2DaemonSet>> WatchNamespacedDaemonSetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2DaemonSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2ReplicaSet>> WatchNamespacedReplicaSetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2ReplicaSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2StatefulSet>> WatchNamespacedStatefulSetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2StatefulSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ReplicaSet
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2ReplicaSet>> WatchReplicaSetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2ReplicaSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StatefulSet
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta2StatefulSet>> WatchStatefulSetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta2StatefulSet> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind AuditSink
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1AuditSink>> WatchAuditSinkAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1AuditSink> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1HorizontalPodAutoscaler>> WatchHorizontalPodAutoscalerForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1HorizontalPodAutoscaler> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1HorizontalPodAutoscaler>> WatchNamespacedHorizontalPodAutoscalerAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1HorizontalPodAutoscaler> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V2beta1HorizontalPodAutoscaler>> WatchHorizontalPodAutoscalerForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V2beta1HorizontalPodAutoscaler> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V2beta1HorizontalPodAutoscaler>> WatchNamespacedHorizontalPodAutoscalerAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V2beta1HorizontalPodAutoscaler> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V2beta2HorizontalPodAutoscaler>> WatchHorizontalPodAutoscalerForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V2beta2HorizontalPodAutoscaler> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind HorizontalPodAutoscaler
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V2beta2HorizontalPodAutoscaler>> WatchNamespacedHorizontalPodAutoscalerAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V2beta2HorizontalPodAutoscaler> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Job
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Job>> WatchJobForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Job> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Job
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Job>> WatchNamespacedJobAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Job> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CronJob
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1CronJob>> WatchCronJobForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1CronJob> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CronJob
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1CronJob>> WatchNamespacedCronJobAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1CronJob> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CronJob
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V2alpha1CronJob>> WatchCronJobForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V2alpha1CronJob> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CronJob
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V2alpha1CronJob>> WatchNamespacedCronJobAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V2alpha1CronJob> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CertificateSigningRequest
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1CertificateSigningRequest>> WatchCertificateSigningRequestAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1CertificateSigningRequest> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Lease
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Lease>> WatchLeaseForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Lease> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Lease
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Lease>> WatchNamespacedLeaseAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Lease> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Lease
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1Lease>> WatchLeaseForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1Lease> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Lease
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1Lease>> WatchNamespacedLeaseAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1Lease> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Event
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1Event>> WatchEventForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1Event> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Event
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1Event>> WatchNamespacedEventAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1Event> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind NetworkPolicy
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1NetworkPolicy>> WatchNamespacedNetworkPolicyAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1NetworkPolicy> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind NetworkPolicy
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1NetworkPolicy>> WatchNetworkPolicyForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1NetworkPolicy> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RuntimeClass
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1RuntimeClass>> WatchRuntimeClassAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1RuntimeClass> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RuntimeClass
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1RuntimeClass>> WatchRuntimeClassAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1RuntimeClass> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PodDisruptionBudget
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1PodDisruptionBudget>> WatchNamespacedPodDisruptionBudgetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1PodDisruptionBudget> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PodDisruptionBudget
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1PodDisruptionBudget>> WatchPodDisruptionBudgetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1PodDisruptionBudget> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ClusterRoleBinding
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ClusterRoleBinding>> WatchClusterRoleBindingAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ClusterRoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ClusterRole
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1ClusterRole>> WatchClusterRoleAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1ClusterRole> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RoleBinding
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1RoleBinding>> WatchNamespacedRoleBindingAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1RoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Role
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Role>> WatchNamespacedRoleAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Role> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RoleBinding
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1RoleBinding>> WatchRoleBindingForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1RoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Role
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1Role>> WatchRoleForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1Role> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ClusterRoleBinding
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1ClusterRoleBinding>> WatchClusterRoleBindingAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1ClusterRoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ClusterRole
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1ClusterRole>> WatchClusterRoleAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1ClusterRole> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RoleBinding
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1RoleBinding>> WatchNamespacedRoleBindingAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1RoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Role
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1Role>> WatchNamespacedRoleAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1Role> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RoleBinding
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1RoleBinding>> WatchRoleBindingForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1RoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Role
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1Role>> WatchRoleForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1Role> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ClusterRoleBinding
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1ClusterRoleBinding>> WatchClusterRoleBindingAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1ClusterRoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind ClusterRole
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1ClusterRole>> WatchClusterRoleAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1ClusterRole> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RoleBinding
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1RoleBinding>> WatchNamespacedRoleBindingAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1RoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Role
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1Role>> WatchNamespacedRoleAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1Role> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind RoleBinding
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1RoleBinding>> WatchRoleBindingForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1RoleBinding> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind Role
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1Role>> WatchRoleForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1Role> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PriorityClass
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1PriorityClass>> WatchPriorityClassAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1PriorityClass> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PriorityClass
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1PriorityClass>> WatchPriorityClassAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1PriorityClass> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PriorityClass
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1PriorityClass>> WatchPriorityClassAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1PriorityClass> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PodPreset
        /// </summary>
        /// <param name="namespace">
        /// object name and auth scope, such as for teams and projects
        /// </param>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1PodPreset>> WatchNamespacedPodPresetAsync(
            string @namespace,
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1PodPreset> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind PodPreset
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1PodPreset>> WatchPodPresetForAllNamespacesAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            bool? pretty = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1PodPreset> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StorageClass
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1StorageClass>> WatchStorageClassAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1StorageClass> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind VolumeAttachment
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1VolumeAttachment>> WatchVolumeAttachmentAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1VolumeAttachment> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind VolumeAttachment
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1alpha1VolumeAttachment>> WatchVolumeAttachmentAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1alpha1VolumeAttachment> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CSIDriver
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1CSIDriver>> WatchCSIDriverAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1CSIDriver> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind CSINode
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1CSINode>> WatchCSINodeAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1CSINode> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind StorageClass
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1StorageClass>> WatchStorageClassAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1StorageClass> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// list or watch objects of kind VolumeAttachment
        /// </summary>
        /// <param name="allowWatchBookmarks">
        /// allowWatchBookmarks requests watch events with type "BOOKMARK". Servers that do not implement bookmarks may ignore this flag and bookmarks are sent at the server's discretion. Clients should not assume bookmarks are returned at any specific interval, nor may they assume the server will send any BOOKMARK event during a session. If this is not a watch, this field is ignored. If the feature gate WatchBookmarks is not enabled in apiserver, this field is ignored.
        /// 
        /// This field is alpha and can be changed or removed without notice.
        /// </param>
        /// <param name="continue">
        /// The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the "next key".
        /// 
        /// This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications.
        /// </param>
        /// <param name="fieldSelector">
        /// A selector to restrict the list of returned objects by their fields. Defaults to everything.
        /// </param>
        /// <param name="labelSelector">
        /// A selector to restrict the list of returned objects by their labels. Defaults to everything.
        /// </param>
        /// <param name="limit">
        /// limit is a maximum number of responses to return for a list call. If more items exist, the server will set the `continue` field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.
        /// 
        /// The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned.
        /// </param>
        /// <param name="resourceVersion">
        /// When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity.
        /// </param>
        /// <param name="watch">
        /// Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion.
        /// </param>
        /// <param name="pretty">
        /// If 'true', then the output is pretty printed.
        /// </param>
        /// <param name="customHeaders">
        /// The headers that will be added to request.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> which can be used to cancel the asynchronous operation.
        /// </param>
        /// <returns>
        /// A <see cref="Task"/> which represents the asynchronous operation, and returns a new watcher.
        /// </returns>
        Task<Watcher<V1beta1VolumeAttachment>> WatchVolumeAttachmentAsync(
            bool? allowWatchBookmarks = null,
            string @continue = null,
            string fieldSelector = null,
            string labelSelector = null,
            int? limit = null,
            string resourceVersion = null,
            int? timeoutSeconds = null,
            bool? watch = null,
            bool? pretty = null,
            Dictionary<string, List<string>> customHeaders = null,
            Action<WatchEventType, V1beta1VolumeAttachment> onEvent = null,
            Action<Exception> onError = null,
            Action onClosed = null,
            CancellationToken cancellationToken = default(CancellationToken));

    }
}
