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

    public partial class WebhookStartProcessDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookStartProcessDto class.
        /// </summary>
        public WebhookStartProcessDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookStartProcessDto class.
        /// </summary>
        /// <param name="releaseKey">The unique key of the release associated
        /// with the process.</param>
        /// <param name="strategy">States which robots from the environment are
        /// being run by the process. Possible values include: 'All',
        /// 'Specific', 'RobotCount', 'JobsCount', 'ModernJobsCount'</param>
        /// <param name="robotIds">The collection of ids of specific robots
        /// selected to be run by the current process. This collection must be
        /// empty only if the start strategy is not Specific.</param>
        /// <param name="jobsCount">Number of pending jobs to be created in the
        /// environment, for the current process. This number must be greater
        /// than 0 only if the start strategy is JobsCount.</param>
        /// <param name="source">The Source of the job starting the current
        /// process. Possible values include: 'Manual', 'Schedule',
        /// 'Queue'</param>
        public WebhookStartProcessDto(System.Guid? releaseKey = default(System.Guid?), WebhookStartProcessDtoStrategy? strategy = default(WebhookStartProcessDtoStrategy?), IList<long?> robotIds = default(IList<long?>), int? jobsCount = default(int?), WebhookStartProcessDtoSource? source = default(WebhookStartProcessDtoSource?))
        {
            ReleaseKey = releaseKey;
            Strategy = strategy;
            RobotIds = robotIds;
            JobsCount = jobsCount;
            Source = source;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the unique key of the release associated with the process.
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseKey")]
        public System.Guid? ReleaseKey { get; private set; }

        /// <summary>
        /// Gets states which robots from the environment are being run by the
        /// process. Possible values include: 'All', 'Specific', 'RobotCount',
        /// 'JobsCount', 'ModernJobsCount'
        /// </summary>
        [JsonProperty(PropertyName = "Strategy")]
        public WebhookStartProcessDtoStrategy? Strategy { get; private set; }

        /// <summary>
        /// Gets the collection of ids of specific robots selected to be run by
        /// the current process. This collection must be empty only if the
        /// start strategy is not Specific.
        /// </summary>
        [JsonProperty(PropertyName = "RobotIds")]
        public IList<long?> RobotIds { get; private set; }

        /// <summary>
        /// Gets number of pending jobs to be created in the environment, for
        /// the current process. This number must be greater than 0 only if the
        /// start strategy is JobsCount.
        /// </summary>
        [JsonProperty(PropertyName = "JobsCount")]
        public int? JobsCount { get; private set; }

        /// <summary>
        /// Gets the Source of the job starting the current process. Possible
        /// values include: 'Manual', 'Schedule', 'Queue'
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public WebhookStartProcessDtoSource? Source { get; private set; }

    }
}
