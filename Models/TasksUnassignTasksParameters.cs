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

    public partial class TasksUnassignTasksParameters
    {
        /// <summary>
        /// Initializes a new instance of the TasksUnassignTasksParameters
        /// class.
        /// </summary>
        public TasksUnassignTasksParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TasksUnassignTasksParameters
        /// class.
        /// </summary>
        public TasksUnassignTasksParameters(IList<long?> taskIds)
        {
            TaskIds = taskIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskIds")]
        public IList<long?> TaskIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaskIds");
            }
        }
    }
}
