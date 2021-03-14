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
    /// Defines values for TaskActivityMetadataDtoActivityType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskActivityMetadataDtoActivityType
    {
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Assigned")]
        Assigned,
        [EnumMember(Value = "ReAssigned")]
        ReAssigned,
        [EnumMember(Value = "UnAssigned")]
        UnAssigned,
        [EnumMember(Value = "Saved")]
        Saved,
        [EnumMember(Value = "Forwarded")]
        Forwarded,
        [EnumMember(Value = "Completed")]
        Completed
    }
    internal static class TaskActivityMetadataDtoActivityTypeEnumExtension
    {
        internal static string ToSerializedValue(this TaskActivityMetadataDtoActivityType? value)
        {
            return value == null ? null : ((TaskActivityMetadataDtoActivityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskActivityMetadataDtoActivityType value)
        {
            switch( value )
            {
                case TaskActivityMetadataDtoActivityType.Created:
                    return "Created";
                case TaskActivityMetadataDtoActivityType.Assigned:
                    return "Assigned";
                case TaskActivityMetadataDtoActivityType.ReAssigned:
                    return "ReAssigned";
                case TaskActivityMetadataDtoActivityType.UnAssigned:
                    return "UnAssigned";
                case TaskActivityMetadataDtoActivityType.Saved:
                    return "Saved";
                case TaskActivityMetadataDtoActivityType.Forwarded:
                    return "Forwarded";
                case TaskActivityMetadataDtoActivityType.Completed:
                    return "Completed";
            }
            return null;
        }

        internal static TaskActivityMetadataDtoActivityType? ParseTaskActivityMetadataDtoActivityType(this string value)
        {
            switch( value )
            {
                case "Created":
                    return TaskActivityMetadataDtoActivityType.Created;
                case "Assigned":
                    return TaskActivityMetadataDtoActivityType.Assigned;
                case "ReAssigned":
                    return TaskActivityMetadataDtoActivityType.ReAssigned;
                case "UnAssigned":
                    return TaskActivityMetadataDtoActivityType.UnAssigned;
                case "Saved":
                    return TaskActivityMetadataDtoActivityType.Saved;
                case "Forwarded":
                    return TaskActivityMetadataDtoActivityType.Forwarded;
                case "Completed":
                    return TaskActivityMetadataDtoActivityType.Completed;
            }
            return null;
        }
    }
}
