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
    /// Defines values for AuditedService.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditedService
    {
        [EnumMember(Value = "Orchestrator")]
        Orchestrator,
        [EnumMember(Value = "TestAutomation")]
        TestAutomation
    }
    internal static class AuditedServiceEnumExtension
    {
        internal static string ToSerializedValue(this AuditedService? value)
        {
            return value == null ? null : ((AuditedService)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuditedService value)
        {
            switch( value )
            {
                case AuditedService.Orchestrator:
                    return "Orchestrator";
                case AuditedService.TestAutomation:
                    return "TestAutomation";
            }
            return null;
        }

        internal static AuditedService? ParseAuditedService(this string value)
        {
            switch( value )
            {
                case "Orchestrator":
                    return AuditedService.Orchestrator;
                case "TestAutomation":
                    return AuditedService.TestAutomation;
            }
            return null;
        }
    }
}
