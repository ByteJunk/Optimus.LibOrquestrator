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

    public partial class ODataValueOfIEnumerableOfWebhookEventTypeDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfWebhookEventTypeDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfWebhookEventTypeDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfWebhookEventTypeDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfWebhookEventTypeDto(IList<WebhookEventTypeDto> value = default(IList<WebhookEventTypeDto>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<WebhookEventTypeDto> Value { get; set; }

    }
}
