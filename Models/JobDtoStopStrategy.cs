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
    /// Defines values for JobDtoStopStrategy.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobDtoStopStrategy
    {
        [EnumMember(Value = "SoftStop")]
        SoftStop,
        [EnumMember(Value = "Kill")]
        Kill
    }
    internal static class JobDtoStopStrategyEnumExtension
    {
        internal static string ToSerializedValue(this JobDtoStopStrategy? value)
        {
            return value == null ? null : ((JobDtoStopStrategy)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobDtoStopStrategy value)
        {
            switch( value )
            {
                case JobDtoStopStrategy.SoftStop:
                    return "SoftStop";
                case JobDtoStopStrategy.Kill:
                    return "Kill";
            }
            return null;
        }

        internal static JobDtoStopStrategy? ParseJobDtoStopStrategy(this string value)
        {
            switch( value )
            {
                case "SoftStop":
                    return JobDtoStopStrategy.SoftStop;
                case "Kill":
                    return JobDtoStopStrategy.Kill;
            }
            return null;
        }
    }
}