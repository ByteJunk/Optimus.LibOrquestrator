// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class HostLicensePerTenantDto
    {
        /// <summary>
        /// Initializes a new instance of the HostLicensePerTenantDto class.
        /// </summary>
        public HostLicensePerTenantDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostLicensePerTenantDto class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="tenantId">The tenant's Id</param>
        /// <param name="hostLicenseId">The host license's Id</param>
        public HostLicensePerTenantDto(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), int? tenantId = default(int?), long? hostLicenseId = default(long?))
        {
            AdditionalProperties = additionalProperties;
            TenantId = tenantId;
            HostLicenseId = hostLicenseId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the tenant's Id
        /// </summary>
        [JsonProperty(PropertyName = "TenantId")]
        public int? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the host license's Id
        /// </summary>
        [JsonProperty(PropertyName = "HostLicenseId")]
        public long? HostLicenseId { get; set; }

    }
}
