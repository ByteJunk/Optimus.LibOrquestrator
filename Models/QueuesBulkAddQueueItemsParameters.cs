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

    public partial class QueuesBulkAddQueueItemsParameters
    {
        /// <summary>
        /// Initializes a new instance of the QueuesBulkAddQueueItemsParameters
        /// class.
        /// </summary>
        public QueuesBulkAddQueueItemsParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueuesBulkAddQueueItemsParameters
        /// class.
        /// </summary>
        /// <param name="commitType">Possible values include: 'AllOrNothing',
        /// 'StopOnFirstFailure', 'ProcessAllIndependently'</param>
        public QueuesBulkAddQueueItemsParameters(BulkAddQueueItemsParametersCommitType commitType, string queueName = default(string), IList<QueueItemDataDto> queueItems = default(IList<QueueItemDataDto>))
        {
            QueueName = queueName;
            CommitType = commitType;
            QueueItems = queueItems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueName")]
        public string QueueName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'AllOrNothing',
        /// 'StopOnFirstFailure', 'ProcessAllIndependently'
        /// </summary>
        [JsonProperty(PropertyName = "commitType")]
        public BulkAddQueueItemsParametersCommitType CommitType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueItems")]
        public IList<QueueItemDataDto> QueueItems { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (QueueItems != null)
            {
                foreach (var element in QueueItems)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
