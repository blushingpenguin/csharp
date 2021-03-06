// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// EndpointPort is a tuple that describes a single port.
    /// </summary>
    public partial class Corev1EndpointPort
    {
        /// <summary>
        /// Initializes a new instance of the Corev1EndpointPort class.
        /// </summary>
        public Corev1EndpointPort()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1EndpointPort class.
        /// </summary>
        /// <param name="port">The port number of the endpoint.</param>
        /// <param name="appProtocol">The application protocol for this port.
        /// This field follows standard Kubernetes label syntax. Un-prefixed
        /// names are reserved for IANA standard service names (as per RFC-6335
        /// and http://www.iana.org/assignments/service-names). Non-standard
        /// protocols should use prefixed names such as
        /// mycompany.com/my-custom-protocol. This is a beta field that is
        /// guarded by the ServiceAppProtocol feature gate and enabled by
        /// default.</param>
        /// <param name="name">The name of this port.  This must match the
        /// 'name' field in the corresponding ServicePort. Must be a DNS_LABEL.
        /// Optional only if one port is defined.</param>
        /// <param name="protocol">The IP protocol for this port. Must be UDP,
        /// TCP, or SCTP. Default is TCP.</param>
        public Corev1EndpointPort(int port, string appProtocol = default(string), string name = default(string), string protocol = default(string))
        {
            AppProtocol = appProtocol;
            Name = name;
            Port = port;
            Protocol = protocol;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the application protocol for this port. This field
        /// follows standard Kubernetes label syntax. Un-prefixed names are
        /// reserved for IANA standard service names (as per RFC-6335 and
        /// http://www.iana.org/assignments/service-names). Non-standard
        /// protocols should use prefixed names such as
        /// mycompany.com/my-custom-protocol. This is a beta field that is
        /// guarded by the ServiceAppProtocol feature gate and enabled by
        /// default.
        /// </summary>
        [JsonProperty(PropertyName = "appProtocol")]
        public string AppProtocol { get; set; }

        /// <summary>
        /// Gets or sets the name of this port.  This must match the 'name'
        /// field in the corresponding ServicePort. Must be a DNS_LABEL.
        /// Optional only if one port is defined.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the port number of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the IP protocol for this port. Must be UDP, TCP, or
        /// SCTP. Default is TCP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
