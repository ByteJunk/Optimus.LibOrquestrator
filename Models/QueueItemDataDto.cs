// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the work item content.
    /// </summary>
    public partial class QueueItemDataDto
    {
        /// <summary>
        /// Initializes a new instance of the QueueItemDataDto class.
        /// </summary>
        public QueueItemDataDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueueItemDataDto class.
        /// </summary>
        /// <param name="name">The name of the queue into which the item will
        /// be added.</param>
        /// <param name="priority">Sets the processing importance for a given
        /// item. Possible values include: 'High', 'Normal', 'Low'</param>
        /// <param name="specificContent">A collection of key value pairs
        /// containing custom data configured in the Add Queue Item activity,
        /// in UiPath Studio.</param>
        /// <param name="deferDate">The earliest date and time at which the
        /// item is available for processing. If empty the item can be
        /// processed as soon as possible.</param>
        /// <param name="dueDate">The latest date and time at which the item
        /// should be processed. If empty the item can be processed at any
        /// given time.</param>
        /// <param name="riskSlaDate">The RiskSla date at time which is
        /// considered as risk zone for the item to be processed.</param>
        /// <param name="reference">An optional, user-specified value for queue
        /// item identification.</param>
        /// <param name="progress">String field which is used to keep track of
        /// the business flow progress.</param>
        public QueueItemDataDto(string name = default(string), QueueItemDataDtoPriority? priority = default(QueueItemDataDtoPriority?), IDictionary<string, object> specificContent = default(IDictionary<string, object>), System.DateTime? deferDate = default(System.DateTime?), System.DateTime? dueDate = default(System.DateTime?), System.DateTime? riskSlaDate = default(System.DateTime?), string reference = default(string), string progress = default(string))
        {
            Name = name;
            Priority = priority;
            SpecificContent = specificContent;
            DeferDate = deferDate;
            DueDate = dueDate;
            RiskSlaDate = riskSlaDate;
            Reference = reference;
            Progress = progress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the queue into which the item will be
        /// added.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets sets the processing importance for a given item.
        /// Possible values include: 'High', 'Normal', 'Low'
        /// </summary>
        [JsonProperty(PropertyName = "Priority")]
        public QueueItemDataDtoPriority? Priority { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs containing custom data
        /// configured in the Add Queue Item activity, in UiPath Studio.
        /// </summary>
        [JsonProperty(PropertyName = "SpecificContent")]
        public IDictionary<string, object> SpecificContent { get; set; }

        /// <summary>
        /// Gets or sets the earliest date and time at which the item is
        /// available for processing. If empty the item can be processed as
        /// soon as possible.
        /// </summary>
        [JsonProperty(PropertyName = "DeferDate")]
        public System.DateTime? DeferDate { get; set; }

        /// <summary>
        /// Gets or sets the latest date and time at which the item should be
        /// processed. If empty the item can be processed at any given time.
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the RiskSla date at time which is considered as risk
        /// zone for the item to be processed.
        /// </summary>
        [JsonProperty(PropertyName = "RiskSlaDate")]
        public System.DateTime? RiskSlaDate { get; set; }

        /// <summary>
        /// Gets or sets an optional, user-specified value for queue item
        /// identification.
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets string field which is used to keep track of the
        /// business flow progress.
        /// </summary>
        [JsonProperty(PropertyName = "Progress")]
        public string Progress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Reference != null)
            {
                if (Reference.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Reference", 128);
                }
                if (Reference.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Reference", 0);
                }
            }
        }
    }
}
