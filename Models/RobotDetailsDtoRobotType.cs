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
    /// Defines values for RobotDetailsDtoRobotType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RobotDetailsDtoRobotType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Studio")]
        Studio,
        [EnumMember(Value = "Development")]
        Development,
        [EnumMember(Value = "StudioX")]
        StudioX,
        [EnumMember(Value = "Headless")]
        Headless,
        [EnumMember(Value = "StudioPro")]
        StudioPro,
        [EnumMember(Value = "TestAutomation")]
        TestAutomation
    }
    internal static class RobotDetailsDtoRobotTypeEnumExtension
    {
        internal static string ToSerializedValue(this RobotDetailsDtoRobotType? value)
        {
            return value == null ? null : ((RobotDetailsDtoRobotType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RobotDetailsDtoRobotType value)
        {
            switch( value )
            {
                case RobotDetailsDtoRobotType.NonProduction:
                    return "NonProduction";
                case RobotDetailsDtoRobotType.Attended:
                    return "Attended";
                case RobotDetailsDtoRobotType.Unattended:
                    return "Unattended";
                case RobotDetailsDtoRobotType.Studio:
                    return "Studio";
                case RobotDetailsDtoRobotType.Development:
                    return "Development";
                case RobotDetailsDtoRobotType.StudioX:
                    return "StudioX";
                case RobotDetailsDtoRobotType.Headless:
                    return "Headless";
                case RobotDetailsDtoRobotType.StudioPro:
                    return "StudioPro";
                case RobotDetailsDtoRobotType.TestAutomation:
                    return "TestAutomation";
            }
            return null;
        }

        internal static RobotDetailsDtoRobotType? ParseRobotDetailsDtoRobotType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return RobotDetailsDtoRobotType.NonProduction;
                case "Attended":
                    return RobotDetailsDtoRobotType.Attended;
                case "Unattended":
                    return RobotDetailsDtoRobotType.Unattended;
                case "Studio":
                    return RobotDetailsDtoRobotType.Studio;
                case "Development":
                    return RobotDetailsDtoRobotType.Development;
                case "StudioX":
                    return RobotDetailsDtoRobotType.StudioX;
                case "Headless":
                    return RobotDetailsDtoRobotType.Headless;
                case "StudioPro":
                    return RobotDetailsDtoRobotType.StudioPro;
                case "TestAutomation":
                    return RobotDetailsDtoRobotType.TestAutomation;
            }
            return null;
        }
    }
}