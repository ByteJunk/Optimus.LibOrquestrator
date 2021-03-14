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
    /// Defines values for LicenseResultDtoErrorCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LicenseResultDtoErrorCode
    {
        [EnumMember(Value = "NoLicense")]
        NoLicense,
        [EnumMember(Value = "LicenseExpired")]
        LicenseExpired,
        [EnumMember(Value = "LicenseUnregistered")]
        LicenseUnregistered,
        [EnumMember(Value = "NoAvailableLicenses")]
        NoAvailableLicenses,
        [EnumMember(Value = "NotEnoughAvailableSlots")]
        NotEnoughAvailableSlots,
        [EnumMember(Value = "NotEnoughRuntimeLicenses")]
        NotEnoughRuntimeLicenses,
        [EnumMember(Value = "LicenseIsAlreadyInUse")]
        LicenseIsAlreadyInUse,
        [EnumMember(Value = "InvalidRequest")]
        InvalidRequest,
        [EnumMember(Value = "SlotsExceedLicenseLimit")]
        SlotsExceedLicenseLimit,
        [EnumMember(Value = "RuntimeDisabled")]
        RuntimeDisabled,
        [EnumMember(Value = "ExternalNotSupported")]
        ExternalNotSupported,
        [EnumMember(Value = "UsageExceedsLicenseLimit")]
        UsageExceedsLicenseLimit,
        [EnumMember(Value = "LicenseNotCompatible")]
        LicenseNotCompatible
    }
    internal static class LicenseResultDtoErrorCodeEnumExtension
    {
        internal static string ToSerializedValue(this LicenseResultDtoErrorCode? value)
        {
            return value == null ? null : ((LicenseResultDtoErrorCode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LicenseResultDtoErrorCode value)
        {
            switch( value )
            {
                case LicenseResultDtoErrorCode.NoLicense:
                    return "NoLicense";
                case LicenseResultDtoErrorCode.LicenseExpired:
                    return "LicenseExpired";
                case LicenseResultDtoErrorCode.LicenseUnregistered:
                    return "LicenseUnregistered";
                case LicenseResultDtoErrorCode.NoAvailableLicenses:
                    return "NoAvailableLicenses";
                case LicenseResultDtoErrorCode.NotEnoughAvailableSlots:
                    return "NotEnoughAvailableSlots";
                case LicenseResultDtoErrorCode.NotEnoughRuntimeLicenses:
                    return "NotEnoughRuntimeLicenses";
                case LicenseResultDtoErrorCode.LicenseIsAlreadyInUse:
                    return "LicenseIsAlreadyInUse";
                case LicenseResultDtoErrorCode.InvalidRequest:
                    return "InvalidRequest";
                case LicenseResultDtoErrorCode.SlotsExceedLicenseLimit:
                    return "SlotsExceedLicenseLimit";
                case LicenseResultDtoErrorCode.RuntimeDisabled:
                    return "RuntimeDisabled";
                case LicenseResultDtoErrorCode.ExternalNotSupported:
                    return "ExternalNotSupported";
                case LicenseResultDtoErrorCode.UsageExceedsLicenseLimit:
                    return "UsageExceedsLicenseLimit";
                case LicenseResultDtoErrorCode.LicenseNotCompatible:
                    return "LicenseNotCompatible";
            }
            return null;
        }

        internal static LicenseResultDtoErrorCode? ParseLicenseResultDtoErrorCode(this string value)
        {
            switch( value )
            {
                case "NoLicense":
                    return LicenseResultDtoErrorCode.NoLicense;
                case "LicenseExpired":
                    return LicenseResultDtoErrorCode.LicenseExpired;
                case "LicenseUnregistered":
                    return LicenseResultDtoErrorCode.LicenseUnregistered;
                case "NoAvailableLicenses":
                    return LicenseResultDtoErrorCode.NoAvailableLicenses;
                case "NotEnoughAvailableSlots":
                    return LicenseResultDtoErrorCode.NotEnoughAvailableSlots;
                case "NotEnoughRuntimeLicenses":
                    return LicenseResultDtoErrorCode.NotEnoughRuntimeLicenses;
                case "LicenseIsAlreadyInUse":
                    return LicenseResultDtoErrorCode.LicenseIsAlreadyInUse;
                case "InvalidRequest":
                    return LicenseResultDtoErrorCode.InvalidRequest;
                case "SlotsExceedLicenseLimit":
                    return LicenseResultDtoErrorCode.SlotsExceedLicenseLimit;
                case "RuntimeDisabled":
                    return LicenseResultDtoErrorCode.RuntimeDisabled;
                case "ExternalNotSupported":
                    return LicenseResultDtoErrorCode.ExternalNotSupported;
                case "UsageExceedsLicenseLimit":
                    return LicenseResultDtoErrorCode.UsageExceedsLicenseLimit;
                case "LicenseNotCompatible":
                    return LicenseResultDtoErrorCode.LicenseNotCompatible;
            }
            return null;
        }
    }
}
