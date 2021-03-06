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

    public partial class JobsStopJobsParameters
    {
        /// <summary>
        /// Initializes a new instance of the JobsStopJobsParameters class.
        /// </summary>
        public JobsStopJobsParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobsStopJobsParameters class.
        /// </summary>
        /// <param name="strategy">Possible values include: 'SoftStop',
        /// 'Kill'</param>
        public JobsStopJobsParameters(IList<long?> jobIds, StopJobsParametersStrategy strategy)
        {
            JobIds = jobIds;
            Strategy = strategy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobIds")]
        public IList<long?> JobIds { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'SoftStop', 'Kill'
        /// </summary>
        [JsonProperty(PropertyName = "strategy")]
        public StopJobsParametersStrategy Strategy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (JobIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JobIds");
            }
        }
    }
}
