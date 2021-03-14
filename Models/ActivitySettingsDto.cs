// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Activity settings
    /// </summary>
    public partial class ActivitySettingsDto
    {
        /// <summary>
        /// Initializes a new instance of the ActivitySettingsDto class.
        /// </summary>
        public ActivitySettingsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivitySettingsDto class.
        /// </summary>
        /// <param name="apiVersion">Current Orchestrator api version</param>
        public ActivitySettingsDto(string apiVersion = default(string), SignalRActivitySettingsDto signalR = default(SignalRActivitySettingsDto))
        {
            ApiVersion = apiVersion;
            SignalR = signalR;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current Orchestrator api version
        /// </summary>
        [JsonProperty(PropertyName = "ApiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SignalR")]
        public SignalRActivitySettingsDto SignalR { get; set; }

    }
}