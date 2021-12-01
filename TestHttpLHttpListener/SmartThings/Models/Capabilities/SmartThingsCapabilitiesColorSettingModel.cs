using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsCapabilitiesRangeModel))]
    public class SmartThingsCapabilitiesColorSettingModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.color_setting"
        [JsonInclude]
        [JsonPropertyName("parameters")]
        public SmartThingsColorSettingParametersModel? Parameters { get; init; }
    }
}
