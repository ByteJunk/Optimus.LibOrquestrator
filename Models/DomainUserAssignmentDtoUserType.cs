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
    /// Defines values for DomainUserAssignmentDtoUserType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DomainUserAssignmentDtoUserType
    {
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "Robot")]
        Robot,
        [EnumMember(Value = "DirectoryUser")]
        DirectoryUser,
        [EnumMember(Value = "DirectoryGroup")]
        DirectoryGroup
    }
    internal static class DomainUserAssignmentDtoUserTypeEnumExtension
    {
        internal static string ToSerializedValue(this DomainUserAssignmentDtoUserType? value)
        {
            return value == null ? null : ((DomainUserAssignmentDtoUserType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DomainUserAssignmentDtoUserType value)
        {
            switch( value )
            {
                case DomainUserAssignmentDtoUserType.User:
                    return "User";
                case DomainUserAssignmentDtoUserType.Robot:
                    return "Robot";
                case DomainUserAssignmentDtoUserType.DirectoryUser:
                    return "DirectoryUser";
                case DomainUserAssignmentDtoUserType.DirectoryGroup:
                    return "DirectoryGroup";
            }
            return null;
        }

        internal static DomainUserAssignmentDtoUserType? ParseDomainUserAssignmentDtoUserType(this string value)
        {
            switch( value )
            {
                case "User":
                    return DomainUserAssignmentDtoUserType.User;
                case "Robot":
                    return DomainUserAssignmentDtoUserType.Robot;
                case "DirectoryUser":
                    return DomainUserAssignmentDtoUserType.DirectoryUser;
                case "DirectoryGroup":
                    return DomainUserAssignmentDtoUserType.DirectoryGroup;
            }
            return null;
        }
    }
}
