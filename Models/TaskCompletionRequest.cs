// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TaskCompletionRequest
    {
        /// <summary>
        /// Initializes a new instance of the TaskCompletionRequest class.
        /// </summary>
        public TaskCompletionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskCompletionRequest class.
        /// </summary>
        /// <param name="taskId">TaskId to retrieve form</param>
        /// <param name="data">Task data json</param>
        /// <param name="action">Action taken on this task</param>
        public TaskCompletionRequest(long taskId, object data = default(object), string action = default(string))
        {
            TaskId = taskId;
            Data = data;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets taskId to retrieve form
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public long TaskId { get; set; }

        /// <summary>
        /// Gets or sets task data json
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets action taken on this task
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
