// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DirectoryPermissionDto
    {
        /// <summary>
        /// Initializes a new instance of the DirectoryPermissionDto class.
        /// </summary>
        public DirectoryPermissionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DirectoryPermissionDto class.
        /// </summary>
        public DirectoryPermissionDto(string directoryGroup = default(string), IList<UserOrganizationUnitDto> organizationUnits = default(IList<UserOrganizationUnitDto>), IList<LightRoleDto> roles = default(IList<LightRoleDto>))
        {
            DirectoryGroup = directoryGroup;
            OrganizationUnits = organizationUnits;
            Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "directoryGroup")]
        public string DirectoryGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationUnits")]
        public IList<UserOrganizationUnitDto> OrganizationUnits { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<LightRoleDto> Roles { get; set; }

    }
}
