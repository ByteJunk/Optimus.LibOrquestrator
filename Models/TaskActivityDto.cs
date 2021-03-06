// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TaskActivityDto
    {
        /// <summary>
        /// Initializes a new instance of the TaskActivityDto class.
        /// </summary>
        public TaskActivityDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskActivityDto class.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="tenantId">Gets or Sets the Tenant Id.</param>
        /// <param name="organizationUnitId">Gets or sets the
        /// folder/organization-unit id.</param>
        /// <param name="taskId">Gets or sets the Id of Task to which this Note
        /// belongs to.</param>
        /// <param name="activityType">Gets or sets the activity type performed
        /// on Task. Possible values include: 'Created', 'Assigned',
        /// 'ReAssigned', 'UnAssigned', 'Saved', 'Forwarded',
        /// 'Completed'</param>
        /// <param name="creatorUserId">Gets or sets the id of the user who
        /// created the Task Note.</param>
        /// <param name="targetUserId">user to whom the Task is assigned on
        /// this activity</param>
        /// <param name="taskNoteId">Gets or sets the Id of the TaskNote
        /// created for this activity.</param>
        /// <param name="creationTime">Gets or sets time at which this task was
        /// created.</param>
        public TaskActivityDto(UserLoginInfoDto creatorUser = default(UserLoginInfoDto), UserLoginInfoDto targetUser = default(UserLoginInfoDto), TaskDto task = default(TaskDto), TaskNoteDto taskNote = default(TaskNoteDto), System.Guid? key = default(System.Guid?), int? tenantId = default(int?), long? organizationUnitId = default(long?), long? taskId = default(long?), TaskActivityMetadataDtoActivityType? activityType = default(TaskActivityMetadataDtoActivityType?), long? creatorUserId = default(long?), long? targetUserId = default(long?), long? taskNoteId = default(long?), System.DateTime? creationTime = default(System.DateTime?), long? id = default(long?))
        {
            CreatorUser = creatorUser;
            TargetUser = targetUser;
            Task = task;
            TaskNote = taskNote;
            Key = key;
            TenantId = tenantId;
            OrganizationUnitId = organizationUnitId;
            TaskId = taskId;
            ActivityType = activityType;
            CreatorUserId = creatorUserId;
            TargetUserId = targetUserId;
            TaskNoteId = taskNoteId;
            CreationTime = creationTime;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatorUser")]
        public UserLoginInfoDto CreatorUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TargetUser")]
        public UserLoginInfoDto TargetUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Task")]
        public TaskDto Task { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TaskNote")]
        public TaskNoteDto TaskNote { get; set; }

        /// <summary>
        /// Gets or sets key
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; set; }

        /// <summary>
        /// Gets or Sets the Tenant Id.
        /// </summary>
        [JsonProperty(PropertyName = "TenantId")]
        public int? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the folder/organization-unit id.
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnitId")]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// Gets or sets the Id of Task to which this Note belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "TaskId")]
        public long? TaskId { get; set; }

        /// <summary>
        /// Gets or sets the activity type performed on Task. Possible values
        /// include: 'Created', 'Assigned', 'ReAssigned', 'UnAssigned',
        /// 'Saved', 'Forwarded', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "ActivityType")]
        public TaskActivityMetadataDtoActivityType? ActivityType { get; set; }

        /// <summary>
        /// Gets or sets the id of the user who created the Task Note.
        /// </summary>
        [JsonProperty(PropertyName = "CreatorUserId")]
        public long? CreatorUserId { get; set; }

        /// <summary>
        /// Gets or sets user to whom the Task is assigned on this activity
        /// </summary>
        [JsonProperty(PropertyName = "TargetUserId")]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the TaskNote created for this activity.
        /// </summary>
        [JsonProperty(PropertyName = "TaskNoteId")]
        public long? TaskNoteId { get; set; }

        /// <summary>
        /// Gets or sets time at which this task was created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
