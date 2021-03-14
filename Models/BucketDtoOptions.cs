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
    /// Defines values for BucketDtoOptions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BucketDtoOptions
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "ReadOnly")]
        ReadOnly,
        [EnumMember(Value = "AuditReadAccess")]
        AuditReadAccess
    }
    internal static class BucketDtoOptionsEnumExtension
    {
        internal static string ToSerializedValue(this BucketDtoOptions? value)
        {
            return value == null ? null : ((BucketDtoOptions)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this BucketDtoOptions value)
        {
            switch( value )
            {
                case BucketDtoOptions.None:
                    return "None";
                case BucketDtoOptions.ReadOnly:
                    return "ReadOnly";
                case BucketDtoOptions.AuditReadAccess:
                    return "AuditReadAccess";
            }
            return null;
        }

        internal static BucketDtoOptions? ParseBucketDtoOptions(this string value)
        {
            switch( value )
            {
                case "None":
                    return BucketDtoOptions.None;
                case "ReadOnly":
                    return BucketDtoOptions.ReadOnly;
                case "AuditReadAccess":
                    return BucketDtoOptions.AuditReadAccess;
            }
            return null;
        }
    }
}