// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TestDataQueueDto
    {
        /// <summary>
        /// Initializes a new instance of the TestDataQueueDto class.
        /// </summary>
        public TestDataQueueDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestDataQueueDto class.
        /// </summary>
        public TestDataQueueDto(string name, string contentJsonSchema, string description = default(string), int? itemsCount = default(int?), int? consumedItemsCount = default(int?), bool? isDeleted = default(bool?), long? deleterUserId = default(long?), System.DateTime? deletionTime = default(System.DateTime?), System.DateTime? lastModificationTime = default(System.DateTime?), long? lastModifierUserId = default(long?), System.DateTime? creationTime = default(System.DateTime?), long? creatorUserId = default(long?), long? id = default(long?))
        {
            Name = name;
            Description = description;
            ContentJsonSchema = contentJsonSchema;
            ItemsCount = itemsCount;
            ConsumedItemsCount = consumedItemsCount;
            IsDeleted = isDeleted;
            DeleterUserId = deleterUserId;
            DeletionTime = deletionTime;
            LastModificationTime = lastModificationTime;
            LastModifierUserId = lastModifierUserId;
            CreationTime = creationTime;
            CreatorUserId = creatorUserId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContentJsonSchema")]
        public string ContentJsonSchema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ItemsCount")]
        public int? ItemsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ConsumedItemsCount")]
        public int? ConsumedItemsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeleterUserId")]
        public long? DeleterUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeletionTime")]
        public System.DateTime? DeletionTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModificationTime")]
        public System.DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastModifierUserId")]
        public long? LastModifierUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatorUserId")]
        public long? CreatorUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (ContentJsonSchema == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentJsonSchema");
            }
            if (Name != null)
            {
                if (Name.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 256);
                }
            }
        }
    }
}