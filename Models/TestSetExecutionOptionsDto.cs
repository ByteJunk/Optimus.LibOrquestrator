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

    public partial class TestSetExecutionOptionsDto
    {
        /// <summary>
        /// Initializes a new instance of the TestSetExecutionOptionsDto class.
        /// </summary>
        public TestSetExecutionOptionsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestSetExecutionOptionsDto class.
        /// </summary>
        /// <param name="triggerType">Possible values include: 'Manual',
        /// 'Scheduled', 'ExternalTool'</param>
        public TestSetExecutionOptionsDto(System.Guid? batchExecutionKey = default(System.Guid?), TestSetExecutionOptionsDtoTriggerType? triggerType = default(TestSetExecutionOptionsDtoTriggerType?), IList<TestCaseExecutionOptionsDto> testCases = default(IList<TestCaseExecutionOptionsDto>), bool? executeOnlySpecifiedTestCases = default(bool?), long? robotId = default(long?), long? machineSessionId = default(long?))
        {
            BatchExecutionKey = batchExecutionKey;
            TriggerType = triggerType;
            TestCases = testCases;
            ExecuteOnlySpecifiedTestCases = executeOnlySpecifiedTestCases;
            RobotId = robotId;
            MachineSessionId = machineSessionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "batchExecutionKey")]
        public System.Guid? BatchExecutionKey { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Manual', 'Scheduled',
        /// 'ExternalTool'
        /// </summary>
        [JsonProperty(PropertyName = "triggerType")]
        public TestSetExecutionOptionsDtoTriggerType? TriggerType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "testCases")]
        public IList<TestCaseExecutionOptionsDto> TestCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executeOnlySpecifiedTestCases")]
        public bool? ExecuteOnlySpecifiedTestCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotId")]
        public long? RobotId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "machineSessionId")]
        public long? MachineSessionId { get; set; }

    }
}
