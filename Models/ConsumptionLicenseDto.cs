// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConsumptionLicenseDto
    {
        /// <summary>
        /// Initializes a new instance of the ConsumptionLicenseDto class.
        /// </summary>
        public ConsumptionLicenseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsumptionLicenseDto class.
        /// </summary>
        public ConsumptionLicenseDto(string reference = default(string), string type = default(string), long? count = default(long?))
        {
            Reference = reference;
            Type = type;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

    }
}
