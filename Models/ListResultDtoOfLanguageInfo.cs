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

    public partial class ListResultDtoOfLanguageInfo
    {
        /// <summary>
        /// Initializes a new instance of the ListResultDtoOfLanguageInfo
        /// class.
        /// </summary>
        public ListResultDtoOfLanguageInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListResultDtoOfLanguageInfo
        /// class.
        /// </summary>
        public ListResultDtoOfLanguageInfo(IList<LanguageInfo> items = default(IList<LanguageInfo>))
        {
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<LanguageInfo> Items { get; set; }

    }
}
