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
    /// Defines values for BaseWebhookTaskDtoStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseWebhookTaskDtoStatus
    {
        [EnumMember(Value = "Unassigned")]
        Unassigned,
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Completed")]
        Completed
    }
    internal static class BaseWebhookTaskDtoStatusEnumExtension
    {
        internal static string ToSerializedValue(this BaseWebhookTaskDtoStatus? value)
        {
            return value == null ? null : ((BaseWebhookTaskDtoStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this BaseWebhookTaskDtoStatus value)
        {
            switch( value )
            {
                case BaseWebhookTaskDtoStatus.Unassigned:
                    return "Unassigned";
                case BaseWebhookTaskDtoStatus.Pending:
                    return "Pending";
                case BaseWebhookTaskDtoStatus.Completed:
                    return "Completed";
            }
            return null;
        }

        internal static BaseWebhookTaskDtoStatus? ParseBaseWebhookTaskDtoStatus(this string value)
        {
            switch( value )
            {
                case "Unassigned":
                    return BaseWebhookTaskDtoStatus.Unassigned;
                case "Pending":
                    return BaseWebhookTaskDtoStatus.Pending;
                case "Completed":
                    return BaseWebhookTaskDtoStatus.Completed;
            }
            return null;
        }
    }
}