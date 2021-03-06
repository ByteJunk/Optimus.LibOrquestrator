// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This class defines DTO for Tasks Collection for webhook event
    /// Task.Forwarded
    /// </summary>
    public partial class WebhookTaskForwardedDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookTaskForwardedDto class.
        /// </summary>
        public WebhookTaskForwardedDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookTaskForwardedDto class.
        /// </summary>
        /// <param name="type">Possible values include: 'FormTask',
        /// 'ExternalTask', 'DocumentValidationTask',
        /// 'DocumentClassificationTask'</param>
        /// <param name="priority">Possible values include: 'Low', 'Medium',
        /// 'High', 'Critical'</param>
        /// <param name="status">Possible values include: 'Unassigned',
        /// 'Pending', 'Completed'</param>
        /// <param name="forwardedByUserId">Id of the user who forwarded this
        /// task</param>
        public WebhookTaskForwardedDto(string title = default(string), BaseWebhookTaskDtoType? type = default(BaseWebhookTaskDtoType?), BaseWebhookTaskDtoPriority? priority = default(BaseWebhookTaskDtoPriority?), BaseWebhookTaskDtoStatus? status = default(BaseWebhookTaskDtoStatus?), System.DateTime? creationTime = default(System.DateTime?), string taskCatalogName = default(string), long? id = default(long?), long? organizationUnitId = default(long?), long? assignedToUserId = default(long?), long? forwardedByUserId = default(long?))
        {
            Title = title;
            Type = type;
            Priority = priority;
            Status = status;
            CreationTime = creationTime;
            TaskCatalogName = taskCatalogName;
            Id = id;
            OrganizationUnitId = organizationUnitId;
            AssignedToUserId = assignedToUserId;
            ForwardedByUserId = forwardedByUserId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; private set; }

        /// <summary>
        /// Gets possible values include: 'FormTask', 'ExternalTask',
        /// 'DocumentValidationTask', 'DocumentClassificationTask'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public BaseWebhookTaskDtoType? Type { get; private set; }

        /// <summary>
        /// Gets possible values include: 'Low', 'Medium', 'High', 'Critical'
        /// </summary>
        [JsonProperty(PropertyName = "Priority")]
        public BaseWebhookTaskDtoPriority? Priority { get; private set; }

        /// <summary>
        /// Gets possible values include: 'Unassigned', 'Pending', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public BaseWebhookTaskDtoStatus? Status { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaskCatalogName")]
        public string TaskCatalogName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnitId")]
        public long? OrganizationUnitId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssignedToUserId")]
        public long? AssignedToUserId { get; private set; }

        /// <summary>
        /// Gets id of the user who forwarded this task
        /// </summary>
        [JsonProperty(PropertyName = "ForwardedByUserId")]
        public long? ForwardedByUserId { get; private set; }

    }
}
