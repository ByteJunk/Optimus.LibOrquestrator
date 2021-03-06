// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ConfigurationEntryValueType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfigurationEntryValueType
    {
        [EnumMember(Value = "String")]
        String,
        [EnumMember(Value = "Number")]
        Number,
        [EnumMember(Value = "Choice")]
        Choice,
        [EnumMember(Value = "Boolean")]
        Boolean,
        [EnumMember(Value = "Section")]
        Section,
        [EnumMember(Value = "Secret")]
        Secret,
        [EnumMember(Value = "SecretFile")]
        SecretFile
    }
    internal static class ConfigurationEntryValueTypeEnumExtension
    {
        internal static string ToSerializedValue(this ConfigurationEntryValueType? value)
        {
            return value == null ? null : ((ConfigurationEntryValueType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ConfigurationEntryValueType value)
        {
            switch( value )
            {
                case ConfigurationEntryValueType.String:
                    return "String";
                case ConfigurationEntryValueType.Number:
                    return "Number";
                case ConfigurationEntryValueType.Choice:
                    return "Choice";
                case ConfigurationEntryValueType.Boolean:
                    return "Boolean";
                case ConfigurationEntryValueType.Section:
                    return "Section";
                case ConfigurationEntryValueType.Secret:
                    return "Secret";
                case ConfigurationEntryValueType.SecretFile:
                    return "SecretFile";
            }
            return null;
        }

        internal static ConfigurationEntryValueType? ParseConfigurationEntryValueType(this string value)
        {
            switch( value )
            {
                case "String":
                    return ConfigurationEntryValueType.String;
                case "Number":
                    return ConfigurationEntryValueType.Number;
                case "Choice":
                    return ConfigurationEntryValueType.Choice;
                case "Boolean":
                    return ConfigurationEntryValueType.Boolean;
                case "Section":
                    return ConfigurationEntryValueType.Section;
                case "Secret":
                    return ConfigurationEntryValueType.Secret;
                case "SecretFile":
                    return ConfigurationEntryValueType.SecretFile;
            }
            return null;
        }
    }
}
