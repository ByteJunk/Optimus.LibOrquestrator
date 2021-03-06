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
    /// Defines values for AssetUserValueDtoValueType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetUserValueDtoValueType
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
    internal static class AssetUserValueDtoValueTypeEnumExtension
    {
        internal static string ToSerializedValue(this AssetUserValueDtoValueType? value)
        {
            return value == null ? null : ((AssetUserValueDtoValueType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AssetUserValueDtoValueType value)
        {
            switch( value )
            {
                case AssetUserValueDtoValueType.DBConnectionString:
                    return "DBConnectionString";
                case AssetUserValueDtoValueType.HttpConnectionString:
                    return "HttpConnectionString";
                case AssetUserValueDtoValueType.Text:
                    return "Text";
                case AssetUserValueDtoValueType.Bool:
                    return "Bool";
                case AssetUserValueDtoValueType.Integer:
                    return "Integer";
                case AssetUserValueDtoValueType.Credential:
                    return "Credential";
                case AssetUserValueDtoValueType.WindowsCredential:
                    return "WindowsCredential";
                case AssetUserValueDtoValueType.KeyValueList:
                    return "KeyValueList";
            }
            return null;
        }

        internal static AssetUserValueDtoValueType? ParseAssetUserValueDtoValueType(this string value)
        {
            switch( value )
            {
                case "DBConnectionString":
                    return AssetUserValueDtoValueType.DBConnectionString;
                case "HttpConnectionString":
                    return AssetUserValueDtoValueType.HttpConnectionString;
                case "Text":
                    return AssetUserValueDtoValueType.Text;
                case "Bool":
                    return AssetUserValueDtoValueType.Bool;
                case "Integer":
                    return AssetUserValueDtoValueType.Integer;
                case "Credential":
                    return AssetUserValueDtoValueType.Credential;
                case "WindowsCredential":
                    return AssetUserValueDtoValueType.WindowsCredential;
                case "KeyValueList":
                    return AssetUserValueDtoValueType.KeyValueList;
            }
            return null;
        }
    }
}
