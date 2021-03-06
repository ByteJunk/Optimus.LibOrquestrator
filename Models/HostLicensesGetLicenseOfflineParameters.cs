// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HostLicensesGetLicenseOfflineParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HostLicensesGetLicenseOfflineParameters class.
        /// </summary>
        public HostLicensesGetLicenseOfflineParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HostLicensesGetLicenseOfflineParameters class.
        /// </summary>
        public HostLicensesGetLicenseOfflineParameters(string licenseKey = default(string), string environment = default(string), string email = default(string))
        {
            LicenseKey = licenseKey;
            Environment = environment;
            Email = email;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public string Environment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

    }
}
