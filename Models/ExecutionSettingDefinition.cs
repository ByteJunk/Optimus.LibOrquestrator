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

    public partial class ExecutionSettingDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ExecutionSettingDefinition class.
        /// </summary>
        public ExecutionSettingDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionSettingDefinition class.
        /// </summary>
        public ExecutionSettingDefinition(string key = default(string), string displayName = default(string), string valueType = default(string), string defaultValue = default(string), IList<string> possibleValues = default(IList<string>))
        {
            Key = key;
            DisplayName = displayName;
            ValueType = valueType;
            DefaultValue = defaultValue;
            PossibleValues = possibleValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ValueType")]
        public string ValueType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PossibleValues")]
        public IList<string> PossibleValues { get; set; }

    }
}
