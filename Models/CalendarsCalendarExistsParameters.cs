// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CalendarsCalendarExistsParameters
    {
        /// <summary>
        /// Initializes a new instance of the CalendarsCalendarExistsParameters
        /// class.
        /// </summary>
        public CalendarsCalendarExistsParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CalendarsCalendarExistsParameters
        /// class.
        /// </summary>
        public CalendarsCalendarExistsParameters(string calendarName = default(string))
        {
            CalendarName = calendarName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarName")]
        public string CalendarName { get; set; }

    }
}
