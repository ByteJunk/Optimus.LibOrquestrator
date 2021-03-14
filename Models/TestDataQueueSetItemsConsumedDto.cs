// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TestDataQueueSetItemsConsumedDto
    {
        /// <summary>
        /// Initializes a new instance of the TestDataQueueSetItemsConsumedDto
        /// class.
        /// </summary>
        public TestDataQueueSetItemsConsumedDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestDataQueueSetItemsConsumedDto
        /// class.
        /// </summary>
        public TestDataQueueSetItemsConsumedDto(IList<long?> itemIds, bool isConsumed)
        {
            ItemIds = itemIds;
            IsConsumed = isConsumed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemIds")]
        public IList<long?> ItemIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isConsumed")]
        public bool IsConsumed { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ItemIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ItemIds");
            }
        }
    }
}
