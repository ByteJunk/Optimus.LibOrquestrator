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
    /// Defines values for MaintenanceSettingState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MaintenanceSettingState
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Draining")]
        Draining,
        [EnumMember(Value = "Suspended")]
        Suspended
    }
    internal static class MaintenanceSettingStateEnumExtension
    {
        internal static string ToSerializedValue(this MaintenanceSettingState? value)
        {
            return value == null ? null : ((MaintenanceSettingState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MaintenanceSettingState value)
        {
            switch( value )
            {
                case MaintenanceSettingState.None:
                    return "None";
                case MaintenanceSettingState.Draining:
                    return "Draining";
                case MaintenanceSettingState.Suspended:
                    return "Suspended";
            }
            return null;
        }

        internal static MaintenanceSettingState? ParseMaintenanceSettingState(this string value)
        {
            switch( value )
            {
                case "None":
                    return MaintenanceSettingState.None;
                case "Draining":
                    return MaintenanceSettingState.Draining;
                case "Suspended":
                    return MaintenanceSettingState.Suspended;
            }
            return null;
        }
    }
}
