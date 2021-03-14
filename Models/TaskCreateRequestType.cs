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
    /// Defines values for TaskCreateRequestType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskCreateRequestType
    {
        [EnumMember(Value = "FormTask")]
        FormTask,
        [EnumMember(Value = "ExternalTask")]
        ExternalTask,
        [EnumMember(Value = "DocumentValidationTask")]
        DocumentValidationTask,
        [EnumMember(Value = "DocumentClassificationTask")]
        DocumentClassificationTask
    }
    internal static class TaskCreateRequestTypeEnumExtension
    {
        internal static string ToSerializedValue(this TaskCreateRequestType? value)
        {
            return value == null ? null : ((TaskCreateRequestType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskCreateRequestType value)
        {
            switch( value )
            {
                case TaskCreateRequestType.FormTask:
                    return "FormTask";
                case TaskCreateRequestType.ExternalTask:
                    return "ExternalTask";
                case TaskCreateRequestType.DocumentValidationTask:
                    return "DocumentValidationTask";
                case TaskCreateRequestType.DocumentClassificationTask:
                    return "DocumentClassificationTask";
            }
            return null;
        }

        internal static TaskCreateRequestType? ParseTaskCreateRequestType(this string value)
        {
            switch( value )
            {
                case "FormTask":
                    return TaskCreateRequestType.FormTask;
                case "ExternalTask":
                    return TaskCreateRequestType.ExternalTask;
                case "DocumentValidationTask":
                    return TaskCreateRequestType.DocumentValidationTask;
                case "DocumentClassificationTask":
                    return TaskCreateRequestType.DocumentClassificationTask;
            }
            return null;
        }
    }
}
