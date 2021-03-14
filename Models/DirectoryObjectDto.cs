// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DirectoryObjectDto
    {
        /// <summary>
        /// Initializes a new instance of the DirectoryObjectDto class.
        /// </summary>
        public DirectoryObjectDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DirectoryObjectDto class.
        /// </summary>
        /// <param name="type">Possible values include: 'User', 'Group',
        /// 'Machine'</param>
        public DirectoryObjectDto(DirectoryObjectDtoType? type = default(DirectoryObjectDtoType?), string source = default(string), string domain = default(string), string identifier = default(string), string identityName = default(string), string displayName = default(string))
        {
            Type = type;
            Source = source;
            Domain = domain;
            Identifier = identifier;
            IdentityName = identityName;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'User', 'Group', 'Machine'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DirectoryObjectDtoType? Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identityName")]
        public string IdentityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

    }
}
