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

    /// <summary>
    /// Defines the properties of a Credential Store.
    /// </summary>
    public partial class CredentialStoreDto
    {
        /// <summary>
        /// Initializes a new instance of the CredentialStoreDto class.
        /// </summary>
        public CredentialStoreDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialStoreDto class.
        /// </summary>
        /// <param name="additionalConfiguration">Additional information
        /// specific to the type of the Credential Store.</param>
        /// <param name="defaultCredentialStores">Default credential
        /// stores</param>
        public CredentialStoreDto(string name, string type, string additionalConfiguration = default(string), CredentialStoreDetailsDto details = default(CredentialStoreDetailsDto), IList<DefaultCredentialStoreDto> defaultCredentialStores = default(IList<DefaultCredentialStoreDto>), long? id = default(long?))
        {
            Name = name;
            Type = type;
            AdditionalConfiguration = additionalConfiguration;
            Details = details;
            DefaultCredentialStores = defaultCredentialStores;
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
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets additional information specific to the type of the
        /// Credential Store.
        /// </summary>
        [JsonProperty(PropertyName = "AdditionalConfiguration")]
        public string AdditionalConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Details")]
        public CredentialStoreDetailsDto Details { get; set; }

        /// <summary>
        /// Gets or sets default credential stores
        /// </summary>
        [JsonProperty(PropertyName = "DefaultCredentialStores")]
        public IList<DefaultCredentialStoreDto> DefaultCredentialStores { get; set; }

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
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (DefaultCredentialStores != null)
            {
                foreach (var element in DefaultCredentialStores)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
