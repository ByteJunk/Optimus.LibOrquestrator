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

    public partial class FolderNavigationContextDto
    {
        /// <summary>
        /// Initializes a new instance of the FolderNavigationContextDto class.
        /// </summary>
        public FolderNavigationContextDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FolderNavigationContextDto class.
        /// </summary>
        /// <param name="provisionType">Possible values include: 'Manual',
        /// 'Automatic'</param>
        public FolderNavigationContextDto(long? id = default(long?), string displayName = default(string), bool? isSelectable = default(bool?), FolderNavigationContextDtoProvisionType? provisionType = default(FolderNavigationContextDtoProvisionType?), IList<SimpleFolderDto> ancestors = default(IList<SimpleFolderDto>), IList<ExtendedFolderDto> childrenPage = default(IList<ExtendedFolderDto>), long? childrenCount = default(long?))
        {
            Id = id;
            DisplayName = displayName;
            IsSelectable = isSelectable;
            ProvisionType = provisionType;
            Ancestors = ancestors;
            ChildrenPage = childrenPage;
            ChildrenCount = childrenCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSelectable")]
        public bool? IsSelectable { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Manual', 'Automatic'
        /// </summary>
        [JsonProperty(PropertyName = "ProvisionType")]
        public FolderNavigationContextDtoProvisionType? ProvisionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Ancestors")]
        public IList<SimpleFolderDto> Ancestors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChildrenPage")]
        public IList<ExtendedFolderDto> ChildrenPage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChildrenCount")]
        public long? ChildrenCount { get; set; }

    }
}
