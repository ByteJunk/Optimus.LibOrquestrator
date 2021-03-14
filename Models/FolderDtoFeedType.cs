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
    /// Defines values for FolderDtoFeedType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FolderDtoFeedType
    {
        [EnumMember(Value = "Undefined")]
        Undefined,
        [EnumMember(Value = "Processes")]
        Processes,
        [EnumMember(Value = "Libraries")]
        Libraries,
        [EnumMember(Value = "PersonalWorkspace")]
        PersonalWorkspace,
        [EnumMember(Value = "FolderHierarchy")]
        FolderHierarchy
    }
    internal static class FolderDtoFeedTypeEnumExtension
    {
        internal static string ToSerializedValue(this FolderDtoFeedType? value)
        {
            return value == null ? null : ((FolderDtoFeedType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FolderDtoFeedType value)
        {
            switch( value )
            {
                case FolderDtoFeedType.Undefined:
                    return "Undefined";
                case FolderDtoFeedType.Processes:
                    return "Processes";
                case FolderDtoFeedType.Libraries:
                    return "Libraries";
                case FolderDtoFeedType.PersonalWorkspace:
                    return "PersonalWorkspace";
                case FolderDtoFeedType.FolderHierarchy:
                    return "FolderHierarchy";
            }
            return null;
        }

        internal static FolderDtoFeedType? ParseFolderDtoFeedType(this string value)
        {
            switch( value )
            {
                case "Undefined":
                    return FolderDtoFeedType.Undefined;
                case "Processes":
                    return FolderDtoFeedType.Processes;
                case "Libraries":
                    return FolderDtoFeedType.Libraries;
                case "PersonalWorkspace":
                    return FolderDtoFeedType.PersonalWorkspace;
                case "FolderHierarchy":
                    return FolderDtoFeedType.FolderHierarchy;
            }
            return null;
        }
    }
}