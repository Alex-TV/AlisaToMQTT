using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsRangeCapabilitiesModel))]
    public class SmartThingsColorSettingCapabilitiesModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.color_setting"
        [JsonInclude]
        [JsonPropertyName("parameters")]
        public SmartThingsColorSettingParametersModel? Parameters { get; init; }
    }
}
