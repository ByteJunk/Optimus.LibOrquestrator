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

    public partial class SimpleUserEntityDto
    {
        /// <summary>
        /// Initializes a new instance of the SimpleUserEntityDto class.
        /// </summary>
        public SimpleUserEntityDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleUserEntityDto class.
        /// </summary>
        /// <param name="type">Possible values include: 'User', 'Robot',
        /// 'DirectoryUser', 'DirectoryGroup'</param>
        public SimpleUserEntityDto(string userName = default(string), bool? isInherited = default(bool?), IList<long?> assignedToFolderIds = default(IList<long?>), bool? mayHaveAttended = default(bool?), bool? mayHaveUnattended = default(bool?), SimpleUserEntityDtoType? type = default(SimpleUserEntityDtoType?), long? id = default(long?))
        {
            UserName = userName;
            IsInherited = isInherited;
            AssignedToFolderIds = assignedToFolderIds;
            MayHaveAttended = mayHaveAttended;
            MayHaveUnattended = mayHaveUnattended;
            Type = type;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsInherited")]
        public bool? IsInherited { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssignedToFolderIds")]
        public IList<long?> AssignedToFolderIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MayHaveAttended")]
        public bool? MayHaveAttended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MayHaveUnattended")]
        public bool? MayHaveUnattended { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'User', 'Robot',
        /// 'DirectoryUser', 'DirectoryGroup'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public SimpleUserEntityDtoType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
