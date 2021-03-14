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
    /// SignalR related settings
    /// </summary>
    public partial class SignalRActivitySettingsDto
    {
        /// <summary>
        /// Initializes a new instance of the SignalRActivitySettingsDto class.
        /// </summary>
        public SignalRActivitySettingsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRActivitySettingsDto class.
        /// </summary>
        /// <param name="url">Absolute url for the SignalR activity hub
        /// endpoint</param>
        /// <param name="skipNegotiation">If true, activity SignalR client
        /// should use websocket transport only and pass SkipNegotation</param>
        public SignalRActivitySettingsDto(string url = default(string), bool? skipNegotiation = default(bool?))
        {
            Url = url;
            SkipNegotiation = skipNegotiation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets absolute url for the SignalR activity hub endpoint
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets if true, activity SignalR client should use websocket
        /// transport only and pass SkipNegotation
        /// </summary>
        [JsonProperty(PropertyName = "skipNegotiation")]
        public bool? SkipNegotiation { get; set; }

    }
}