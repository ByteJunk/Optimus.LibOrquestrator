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

    /// <summary>
    /// Association between a user and a set of roles.
    /// </summary>
    public partial class UserRolesDto
    {
        /// <summary>
        /// Initializes a new instance of the UserRolesDto class.
        /// </summary>
        public UserRolesDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserRolesDto class.
        /// </summary>
        public UserRolesDto(SimpleUserEntityDto userEntity = default(SimpleUserEntityDto), IList<SimpleRoleDto> roles = default(IList<SimpleRoleDto>), long? id = default(long?))
        {
            UserEntity = userEntity;
            Roles = roles;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserEntity")]
        public SimpleUserEntityDto UserEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Roles")]
        public IList<SimpleRoleDto> Roles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
