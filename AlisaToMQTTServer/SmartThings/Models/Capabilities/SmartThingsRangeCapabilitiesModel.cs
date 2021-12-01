using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsRangeCapabilitiesModel))]
    public class SmartThingsRangeCapabilitiesModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.range",
        [JsonInclude]
        [JsonPropertyName("parameters")]
        public SmartThingsRangeParametersModel? Parameters { get; init; }
    }
}
