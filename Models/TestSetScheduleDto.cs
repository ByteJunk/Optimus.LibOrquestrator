// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TestSetScheduleDto
    {
        /// <summary>
        /// Initializes a new instance of the TestSetScheduleDto class.
        /// </summary>
        public TestSetScheduleDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestSetScheduleDto class.
        /// </summary>
        public TestSetScheduleDto(string name, long testSetId, string timeZoneId, bool? enabled = default(bool?), string description = default(string), string testSetName = default(string), string timeZoneIana = default(string), long? calendarId = default(long?), string calendarName = default(string), string cronExpression = default(string), string cronDetails = default(string), string cronSummary = default(string), System.DateTime? nextOccurrence = default(System.DateTime?), System.DateTime? disableDate = default(System.DateTime?), string externalJobKey = default(string), long? id = default(long?))
        {
            Enabled = enabled;
            Name = name;
            Description = description;
            TestSetId = testSetId;
            TestSetName = testSetName;
            TimeZoneId = timeZoneId;
            TimeZoneIana = timeZoneIana;
            CalendarId = calendarId;
            CalendarName = calendarName;
            CronExpression = cronExpression;
            CronDetails = cronDetails;
            CronSummary = cronSummary;
            NextOccurrence = nextOccurrence;
            DisableDate = disableDate;
            ExternalJobKey = externalJobKey;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestSetId")]
        public long TestSetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestSetName")]
        public string TestSetName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeZoneId")]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeZoneIana")]
        public string TimeZoneIana { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CalendarId")]
        public long? CalendarId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CalendarName")]
        public string CalendarName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CronExpression")]
        public string CronExpression { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CronDetails")]
        public string CronDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CronSummary")]
        public string CronSummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NextOccurrence")]
        public System.DateTime? NextOccurrence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisableDate")]
        public System.DateTime? DisableDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalJobKey")]
        public string ExternalJobKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (TimeZoneId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeZoneId");
            }
            if (Name != null)
            {
                if (Name.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 256);
                }
            }
            if (TimeZoneId != null)
            {
                if (TimeZoneId.Length > 80)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "TimeZoneId", 80);
                }
            }
        }
    }
}
