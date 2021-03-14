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
    /// Defines values for BaseWebhookTaskDtoPriority.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseWebhookTaskDtoPriority
    {
        [EnumMember(Value = "Low")]
        Low,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Critical")]
        Critical
    }
    internal static class BaseWebhookTaskDtoPriorityEnumExtension
    {
        internal static string ToSerializedValue(this BaseWebhookTaskDtoPriority? value)
        {
            return value == null ? null : ((BaseWebhookTaskDtoPriority)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this BaseWebhookTaskDtoPriority value)
        {
            switch( value )
            {
                case BaseWebhookTaskDtoPriority.Low:
                    return "Low";
                case BaseWebhookTaskDtoPriority.Medium:
                    return "Medium";
                case BaseWebhookTaskDtoPriority.High:
                    return "High";
                case BaseWebhookTaskDtoPriority.Critical:
                    return "Critical";
            }
            return null;
        }

        internal static BaseWebhookTaskDtoPriority? ParseBaseWebhookTaskDtoPriority(this string value)
        {
            switch( value )
            {
                case "Low":
                    return BaseWebhookTaskDtoPriority.Low;
                case "Medium":
                    return BaseWebhookTaskDtoPriority.Medium;
                case "High":
                    return BaseWebhookTaskDtoPriority.High;
                case "Critical":
                    return BaseWebhookTaskDtoPriority.Critical;
            }
            return null;
        }
    }
}
