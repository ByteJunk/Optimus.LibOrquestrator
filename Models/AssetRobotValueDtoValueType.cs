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
    /// Defines values for AssetRobotValueDtoValueType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetRobotValueDtoValueType
    {
        [EnumMember(Value = "DBConnectionString")]
        DBConnectionString,
        [EnumMember(Value = "HttpConnectionString")]
        HttpConnectionString,
        [EnumMember(Value = "Text")]
        Text,
        [EnumMember(Value = "Bool")]
        Bool,
        [EnumMember(Value = "Integer")]
        Integer,
        [EnumMember(Value = "Credential")]
        Credential,
        [EnumMember(Value = "WindowsCredential")]
        WindowsCredential,
        [EnumMember(Value = "KeyValueList")]
        KeyValueList
    }
    internal static class AssetRobotValueDtoValueTypeEnumExtension
    {
        internal static string ToSerializedValue(this AssetRobotValueDtoValueType? value)
        {
            return value == null ? null : ((AssetRobotValueDtoValueType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AssetRobotValueDtoValueType value)
        {
            switch( value )
            {
                case AssetRobotValueDtoValueType.DBConnectionString:
                    return "DBConnectionString";
                case AssetRobotValueDtoValueType.HttpConnectionString:
                    return "HttpConnectionString";
                case AssetRobotValueDtoValueType.Text:
                    return "Text";
                case AssetRobotValueDtoValueType.Bool:
                    return "Bool";
                case AssetRobotValueDtoValueType.Integer:
                    return "Integer";
                case AssetRobotValueDtoValueType.Credential:
                    return "Credential";
                case AssetRobotValueDtoValueType.WindowsCredential:
                    return "WindowsCredential";
                case AssetRobotValueDtoValueType.KeyValueList:
                    return "KeyValueList";
            }
            return null;
        }

        internal static AssetRobotValueDtoValueType? ParseAssetRobotValueDtoValueType(this string value)
        {
            switch( value )
            {
                case "DBConnectionString":
                    return AssetRobotValueDtoValueType.DBConnectionString;
                case "HttpConnectionString":
                    return AssetRobotValueDtoValueType.HttpConnectionString;
                case "Text":
                    return AssetRobotValueDtoValueType.Text;
                case "Bool":
                    return AssetRobotValueDtoValueType.Bool;
                case "Integer":
                    return AssetRobotValueDtoValueType.Integer;
                case "Credential":
                    return AssetRobotValueDtoValueType.Credential;
                case "WindowsCredential":
                    return AssetRobotValueDtoValueType.WindowsCredential;
                case "KeyValueList":
                    return AssetRobotValueDtoValueType.KeyValueList;
            }
            return null;
        }
    }
}