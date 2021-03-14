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

    public partial class TestCaseExecutionOptionsDto
    {
        /// <summary>
        /// Initializes a new instance of the TestCaseExecutionOptionsDto
        /// class.
        /// </summary>
        public TestCaseExecutionOptionsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestCaseExecutionOptionsDto
        /// class.
        /// </summary>
        public TestCaseExecutionOptionsDto(System.Guid uniqueId, string packageIdentifier = default(string), IList<object> inputArgumentsVariations = default(IList<object>))
        {
            UniqueId = uniqueId;
            PackageIdentifier = packageIdentifier;
            InputArgumentsVariations = inputArgumentsVariations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniqueId")]
        public System.Guid UniqueId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageIdentifier")]
        public string PackageIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inputArgumentsVariations")]
        public IList<object> InputArgumentsVariations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
