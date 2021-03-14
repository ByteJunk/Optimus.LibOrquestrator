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

    public partial class BuildTestSetRequestMessage
    {
        /// <summary>
        /// Initializes a new instance of the BuildTestSetRequestMessage class.
        /// </summary>
        public BuildTestSetRequestMessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildTestSetRequestMessage class.
        /// </summary>
        public BuildTestSetRequestMessage(long releaseId, string versionNumber, IList<System.Guid?> testCaseUniqueIds = default(IList<System.Guid?>))
        {
            ReleaseId = releaseId;
            VersionNumber = versionNumber;
            TestCaseUniqueIds = testCaseUniqueIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "releaseId")]
        public long ReleaseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionNumber")]
        public string VersionNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testCaseUniqueIds")]
        public IList<System.Guid?> TestCaseUniqueIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VersionNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VersionNumber");
            }
        }
    }
}
