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

    public partial class ODataValueOfIEnumerableOfWebhookDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfWebhookDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfWebhookDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfWebhookDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfWebhookDto(IList<WebhookDto> value = default(IList<WebhookDto>))
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
        public IList<WebhookDto> Value { get; set; }

    }
}
