// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Overhead structure represents the resource overhead associated with
    /// running a pod.
    /// </summary>
    public partial class V1Overhead
    {
        /// <summary>
        /// Initializes a new instance of the V1Overhead class.
        /// </summary>
        public V1Overhead()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Overhead class.
        /// </summary>
        /// <param name="podFixed">PodFixed represents the fixed resource
        /// overhead associated with running a pod.</param>
        public V1Overhead(IDictionary<string, ResourceQuantity> podFixed = default(IDictionary<string, ResourceQuantity>))
        {
            PodFixed = podFixed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets podFixed represents the fixed resource overhead
        /// associated with running a pod.
        /// </summary>
        [JsonProperty(PropertyName = "podFixed")]
        public IDictionary<string, ResourceQuantity> PodFixed { get; set; }

    }
}
