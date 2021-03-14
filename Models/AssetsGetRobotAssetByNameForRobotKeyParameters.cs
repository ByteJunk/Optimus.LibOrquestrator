// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AssetsGetRobotAssetByNameForRobotKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AssetsGetRobotAssetByNameForRobotKeyParameters class.
        /// </summary>
        public AssetsGetRobotAssetByNameForRobotKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AssetsGetRobotAssetByNameForRobotKeyParameters class.
        /// </summary>
        public AssetsGetRobotAssetByNameForRobotKeyParameters(string robotKey = default(string), string assetName = default(string))
        {
            RobotKey = robotKey;
            AssetName = assetName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotKey")]
        public string RobotKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assetName")]
        public string AssetName { get; set; }

    }
}
