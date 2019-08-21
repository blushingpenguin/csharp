using k8s.Models;
using System; 
using System.Collections.Generic; 
using System.Threading; 
using System.Threading.Tasks; 

namespace k8s
{
    public partial class Kubernetes
    {
        /// <inheritdoc>
        public Task<Watcher<V1ComponentStatus>> WatchComponentStatusAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/componentstatuses";
            return WatchObjectAsync<V1ComponentStatus>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ConfigMap>> WatchConfigMapForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/configmaps";
            return WatchObjectAsync<V1ConfigMap>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Endpoints>> WatchEndpointsForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/endpoints";
            return WatchObjectAsync<V1Endpoints>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Event>> WatchEventForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/events";
            return WatchObjectAsync<V1Event>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1LimitRange>> WatchLimitRangeForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/limitranges";
            return WatchObjectAsync<V1LimitRange>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Namespace>> WatchNamespaceAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces";
            return WatchObjectAsync<V1Namespace>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ConfigMap>> WatchNamespacedConfigMapAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/configmaps";
            return WatchObjectAsync<V1ConfigMap>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Endpoints>> WatchNamespacedEndpointsAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/endpoints";
            return WatchObjectAsync<V1Endpoints>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Event>> WatchNamespacedEventAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/events";
            return WatchObjectAsync<V1Event>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1LimitRange>> WatchNamespacedLimitRangeAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/limitranges";
            return WatchObjectAsync<V1LimitRange>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1PersistentVolumeClaim>> WatchNamespacedPersistentVolumeClaimAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/persistentvolumeclaims";
            return WatchObjectAsync<V1PersistentVolumeClaim>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Pod>> WatchNamespacedPodAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/pods";
            return WatchObjectAsync<V1Pod>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1PodTemplate>> WatchNamespacedPodTemplateAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/podtemplates";
            return WatchObjectAsync<V1PodTemplate>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ReplicationController>> WatchNamespacedReplicationControllerAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/replicationcontrollers";
            return WatchObjectAsync<V1ReplicationController>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ResourceQuota>> WatchNamespacedResourceQuotaAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/resourcequotas";
            return WatchObjectAsync<V1ResourceQuota>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Secret>> WatchNamespacedSecretAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/secrets";
            return WatchObjectAsync<V1Secret>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ServiceAccount>> WatchNamespacedServiceAccountAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/serviceaccounts";
            return WatchObjectAsync<V1ServiceAccount>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Service>> WatchNamespacedServiceAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/namespaces/{@namespace}/services";
            return WatchObjectAsync<V1Service>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Node>> WatchNodeAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/nodes";
            return WatchObjectAsync<V1Node>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1PersistentVolumeClaim>> WatchPersistentVolumeClaimForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/persistentvolumeclaims";
            return WatchObjectAsync<V1PersistentVolumeClaim>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1PersistentVolume>> WatchPersistentVolumeAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/persistentvolumes";
            return WatchObjectAsync<V1PersistentVolume>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Pod>> WatchPodForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/pods";
            return WatchObjectAsync<V1Pod>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1PodTemplate>> WatchPodTemplateForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/podtemplates";
            return WatchObjectAsync<V1PodTemplate>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ReplicationController>> WatchReplicationControllerForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/replicationcontrollers";
            return WatchObjectAsync<V1ReplicationController>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ResourceQuota>> WatchResourceQuotaForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/resourcequotas";
            return WatchObjectAsync<V1ResourceQuota>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Secret>> WatchSecretForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/secrets";
            return WatchObjectAsync<V1Secret>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ServiceAccount>> WatchServiceAccountForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/serviceaccounts";
            return WatchObjectAsync<V1ServiceAccount>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Service>> WatchServiceForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"api/v1/services";
            return WatchObjectAsync<V1Service>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1MutatingWebhookConfiguration>> WatchMutatingWebhookConfigurationAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/admissionregistration.k8s.io/v1beta1/mutatingwebhookconfigurations";
            return WatchObjectAsync<V1beta1MutatingWebhookConfiguration>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1ValidatingWebhookConfiguration>> WatchValidatingWebhookConfigurationAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/admissionregistration.k8s.io/v1beta1/validatingwebhookconfigurations";
            return WatchObjectAsync<V1beta1ValidatingWebhookConfiguration>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1CustomResourceDefinition>> WatchCustomResourceDefinitionAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apiextensions.k8s.io/v1beta1/customresourcedefinitions";
            return WatchObjectAsync<V1beta1CustomResourceDefinition>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1APIService>> WatchAPIServiceAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apiregistration.k8s.io/v1/apiservices";
            return WatchObjectAsync<V1APIService>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1APIService>> WatchAPIServiceAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apiregistration.k8s.io/v1beta1/apiservices";
            return WatchObjectAsync<V1beta1APIService>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ControllerRevision>> WatchControllerRevisionForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/controllerrevisions";
            return WatchObjectAsync<V1ControllerRevision>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1DaemonSet>> WatchDaemonSetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/daemonsets";
            return WatchObjectAsync<V1DaemonSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Deployment>> WatchDeploymentForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/deployments";
            return WatchObjectAsync<V1Deployment>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ControllerRevision>> WatchNamespacedControllerRevisionAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/namespaces/{@namespace}/controllerrevisions";
            return WatchObjectAsync<V1ControllerRevision>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1DaemonSet>> WatchNamespacedDaemonSetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/namespaces/{@namespace}/daemonsets";
            return WatchObjectAsync<V1DaemonSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Deployment>> WatchNamespacedDeploymentAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/namespaces/{@namespace}/deployments";
            return WatchObjectAsync<V1Deployment>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ReplicaSet>> WatchNamespacedReplicaSetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/namespaces/{@namespace}/replicasets";
            return WatchObjectAsync<V1ReplicaSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1StatefulSet>> WatchNamespacedStatefulSetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/namespaces/{@namespace}/statefulsets";
            return WatchObjectAsync<V1StatefulSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ReplicaSet>> WatchReplicaSetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/replicasets";
            return WatchObjectAsync<V1ReplicaSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1StatefulSet>> WatchStatefulSetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1/statefulsets";
            return WatchObjectAsync<V1StatefulSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1ControllerRevision>> WatchControllerRevisionForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta1/controllerrevisions";
            return WatchObjectAsync<V1beta1ControllerRevision>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1ControllerRevision>> WatchNamespacedControllerRevisionAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta1/namespaces/{@namespace}/controllerrevisions";
            return WatchObjectAsync<V1beta1ControllerRevision>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1StatefulSet>> WatchNamespacedStatefulSetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta1/namespaces/{@namespace}/statefulsets";
            return WatchObjectAsync<V1beta1StatefulSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1StatefulSet>> WatchStatefulSetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta1/statefulsets";
            return WatchObjectAsync<V1beta1StatefulSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2ControllerRevision>> WatchControllerRevisionForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/controllerrevisions";
            return WatchObjectAsync<V1beta2ControllerRevision>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2DaemonSet>> WatchDaemonSetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/daemonsets";
            return WatchObjectAsync<V1beta2DaemonSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2Deployment>> WatchDeploymentForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/deployments";
            return WatchObjectAsync<V1beta2Deployment>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2ControllerRevision>> WatchNamespacedControllerRevisionAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/namespaces/{@namespace}/controllerrevisions";
            return WatchObjectAsync<V1beta2ControllerRevision>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2DaemonSet>> WatchNamespacedDaemonSetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/namespaces/{@namespace}/daemonsets";
            return WatchObjectAsync<V1beta2DaemonSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2ReplicaSet>> WatchNamespacedReplicaSetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/namespaces/{@namespace}/replicasets";
            return WatchObjectAsync<V1beta2ReplicaSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2StatefulSet>> WatchNamespacedStatefulSetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/namespaces/{@namespace}/statefulsets";
            return WatchObjectAsync<V1beta2StatefulSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2ReplicaSet>> WatchReplicaSetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/replicasets";
            return WatchObjectAsync<V1beta2ReplicaSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta2StatefulSet>> WatchStatefulSetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/apps/v1beta2/statefulsets";
            return WatchObjectAsync<V1beta2StatefulSet>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1AuditSink>> WatchAuditSinkAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/auditregistration.k8s.io/v1alpha1/auditsinks";
            return WatchObjectAsync<V1alpha1AuditSink>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1HorizontalPodAutoscaler>> WatchHorizontalPodAutoscalerForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/autoscaling/v1/horizontalpodautoscalers";
            return WatchObjectAsync<V1HorizontalPodAutoscaler>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1HorizontalPodAutoscaler>> WatchNamespacedHorizontalPodAutoscalerAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/autoscaling/v1/namespaces/{@namespace}/horizontalpodautoscalers";
            return WatchObjectAsync<V1HorizontalPodAutoscaler>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V2beta1HorizontalPodAutoscaler>> WatchHorizontalPodAutoscalerForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/autoscaling/v2beta1/horizontalpodautoscalers";
            return WatchObjectAsync<V2beta1HorizontalPodAutoscaler>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V2beta1HorizontalPodAutoscaler>> WatchNamespacedHorizontalPodAutoscalerAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/autoscaling/v2beta1/namespaces/{@namespace}/horizontalpodautoscalers";
            return WatchObjectAsync<V2beta1HorizontalPodAutoscaler>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V2beta2HorizontalPodAutoscaler>> WatchHorizontalPodAutoscalerForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/autoscaling/v2beta2/horizontalpodautoscalers";
            return WatchObjectAsync<V2beta2HorizontalPodAutoscaler>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V2beta2HorizontalPodAutoscaler>> WatchNamespacedHorizontalPodAutoscalerAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/autoscaling/v2beta2/namespaces/{@namespace}/horizontalpodautoscalers";
            return WatchObjectAsync<V2beta2HorizontalPodAutoscaler>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Job>> WatchJobForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/batch/v1/jobs";
            return WatchObjectAsync<V1Job>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Job>> WatchNamespacedJobAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/batch/v1/namespaces/{@namespace}/jobs";
            return WatchObjectAsync<V1Job>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1CronJob>> WatchCronJobForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/batch/v1beta1/cronjobs";
            return WatchObjectAsync<V1beta1CronJob>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1CronJob>> WatchNamespacedCronJobAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/batch/v1beta1/namespaces/{@namespace}/cronjobs";
            return WatchObjectAsync<V1beta1CronJob>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V2alpha1CronJob>> WatchCronJobForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/batch/v2alpha1/cronjobs";
            return WatchObjectAsync<V2alpha1CronJob>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V2alpha1CronJob>> WatchNamespacedCronJobAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/batch/v2alpha1/namespaces/{@namespace}/cronjobs";
            return WatchObjectAsync<V2alpha1CronJob>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1CertificateSigningRequest>> WatchCertificateSigningRequestAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/certificates.k8s.io/v1beta1/certificatesigningrequests";
            return WatchObjectAsync<V1beta1CertificateSigningRequest>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Lease>> WatchLeaseForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/coordination.k8s.io/v1/leases";
            return WatchObjectAsync<V1Lease>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Lease>> WatchNamespacedLeaseAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/coordination.k8s.io/v1/namespaces/{@namespace}/leases";
            return WatchObjectAsync<V1Lease>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1Lease>> WatchLeaseForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/coordination.k8s.io/v1beta1/leases";
            return WatchObjectAsync<V1beta1Lease>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1Lease>> WatchNamespacedLeaseAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/coordination.k8s.io/v1beta1/namespaces/{@namespace}/leases";
            return WatchObjectAsync<V1beta1Lease>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1Event>> WatchEventForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/events.k8s.io/v1beta1/events";
            return WatchObjectAsync<V1beta1Event>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1Event>> WatchNamespacedEventAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/events.k8s.io/v1beta1/namespaces/{@namespace}/events";
            return WatchObjectAsync<V1beta1Event>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1NetworkPolicy>> WatchNamespacedNetworkPolicyAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/networking.k8s.io/v1/namespaces/{@namespace}/networkpolicies";
            return WatchObjectAsync<V1NetworkPolicy>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1NetworkPolicy>> WatchNetworkPolicyForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/networking.k8s.io/v1/networkpolicies";
            return WatchObjectAsync<V1NetworkPolicy>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1RuntimeClass>> WatchRuntimeClassAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/node.k8s.io/v1alpha1/runtimeclasses";
            return WatchObjectAsync<V1alpha1RuntimeClass>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1RuntimeClass>> WatchRuntimeClassAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/node.k8s.io/v1beta1/runtimeclasses";
            return WatchObjectAsync<V1beta1RuntimeClass>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1PodDisruptionBudget>> WatchNamespacedPodDisruptionBudgetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/policy/v1beta1/namespaces/{@namespace}/poddisruptionbudgets";
            return WatchObjectAsync<V1beta1PodDisruptionBudget>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1PodDisruptionBudget>> WatchPodDisruptionBudgetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/policy/v1beta1/poddisruptionbudgets";
            return WatchObjectAsync<V1beta1PodDisruptionBudget>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ClusterRoleBinding>> WatchClusterRoleBindingAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1/clusterrolebindings";
            return WatchObjectAsync<V1ClusterRoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1ClusterRole>> WatchClusterRoleAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1/clusterroles";
            return WatchObjectAsync<V1ClusterRole>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1RoleBinding>> WatchNamespacedRoleBindingAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1/namespaces/{@namespace}/rolebindings";
            return WatchObjectAsync<V1RoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Role>> WatchNamespacedRoleAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1/namespaces/{@namespace}/roles";
            return WatchObjectAsync<V1Role>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1RoleBinding>> WatchRoleBindingForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1/rolebindings";
            return WatchObjectAsync<V1RoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1Role>> WatchRoleForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1/roles";
            return WatchObjectAsync<V1Role>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1ClusterRoleBinding>> WatchClusterRoleBindingAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings";
            return WatchObjectAsync<V1alpha1ClusterRoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1ClusterRole>> WatchClusterRoleAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1alpha1/clusterroles";
            return WatchObjectAsync<V1alpha1ClusterRole>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1RoleBinding>> WatchNamespacedRoleBindingAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1alpha1/namespaces/{@namespace}/rolebindings";
            return WatchObjectAsync<V1alpha1RoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1Role>> WatchNamespacedRoleAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1alpha1/namespaces/{@namespace}/roles";
            return WatchObjectAsync<V1alpha1Role>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1RoleBinding>> WatchRoleBindingForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1alpha1/rolebindings";
            return WatchObjectAsync<V1alpha1RoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1Role>> WatchRoleForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1alpha1/roles";
            return WatchObjectAsync<V1alpha1Role>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1ClusterRoleBinding>> WatchClusterRoleBindingAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1beta1/clusterrolebindings";
            return WatchObjectAsync<V1beta1ClusterRoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1ClusterRole>> WatchClusterRoleAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1beta1/clusterroles";
            return WatchObjectAsync<V1beta1ClusterRole>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1RoleBinding>> WatchNamespacedRoleBindingAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1beta1/namespaces/{@namespace}/rolebindings";
            return WatchObjectAsync<V1beta1RoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1Role>> WatchNamespacedRoleAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1beta1/namespaces/{@namespace}/roles";
            return WatchObjectAsync<V1beta1Role>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1RoleBinding>> WatchRoleBindingForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1beta1/rolebindings";
            return WatchObjectAsync<V1beta1RoleBinding>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1Role>> WatchRoleForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/rbac.authorization.k8s.io/v1beta1/roles";
            return WatchObjectAsync<V1beta1Role>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1PriorityClass>> WatchPriorityClassAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/scheduling.k8s.io/v1/priorityclasses";
            return WatchObjectAsync<V1PriorityClass>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1PriorityClass>> WatchPriorityClassAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/scheduling.k8s.io/v1alpha1/priorityclasses";
            return WatchObjectAsync<V1alpha1PriorityClass>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1PriorityClass>> WatchPriorityClassAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/scheduling.k8s.io/v1beta1/priorityclasses";
            return WatchObjectAsync<V1beta1PriorityClass>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1PodPreset>> WatchNamespacedPodPresetAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/settings.k8s.io/v1alpha1/namespaces/{@namespace}/podpresets";
            return WatchObjectAsync<V1alpha1PodPreset>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1PodPreset>> WatchPodPresetForAllNamespacesAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/settings.k8s.io/v1alpha1/podpresets";
            return WatchObjectAsync<V1alpha1PodPreset>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1StorageClass>> WatchStorageClassAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/storage.k8s.io/v1/storageclasses";
            return WatchObjectAsync<V1StorageClass>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1VolumeAttachment>> WatchVolumeAttachmentAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/storage.k8s.io/v1/volumeattachments";
            return WatchObjectAsync<V1VolumeAttachment>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1alpha1VolumeAttachment>> WatchVolumeAttachmentAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/storage.k8s.io/v1alpha1/volumeattachments";
            return WatchObjectAsync<V1alpha1VolumeAttachment>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1CSIDriver>> WatchCSIDriverAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/storage.k8s.io/v1beta1/csidrivers";
            return WatchObjectAsync<V1beta1CSIDriver>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1CSINode>> WatchCSINodeAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/storage.k8s.io/v1beta1/csinodes";
            return WatchObjectAsync<V1beta1CSINode>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1StorageClass>> WatchStorageClassAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/storage.k8s.io/v1beta1/storageclasses";
            return WatchObjectAsync<V1beta1StorageClass>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

        /// <inheritdoc>
        public Task<Watcher<V1beta1VolumeAttachment>> WatchVolumeAttachmentAsync(
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
            CancellationToken cancellationToken = default(CancellationToken))
        {
            string path = $"apis/storage.k8s.io/v1beta1/volumeattachments";
            return WatchObjectAsync<V1beta1VolumeAttachment>(path: path, @continue: @continue, fieldSelector: fieldSelector, labelSelector: labelSelector, limit: limit, pretty: pretty, timeoutSeconds: timeoutSeconds, resourceVersion: resourceVersion, customHeaders: customHeaders, onEvent: onEvent, onError: onError, onClosed: onClosed, cancellationToken: cancellationToken);
        }

    }
}
