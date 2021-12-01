using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsOnOffCapabilitiesModel))]
    public class SmartThingsToggleCapabilitiesModel : SmartThingsCapabilitiesModel
    {

        //"devices.capabilities.toggle"
        [JsonInclude]
        [JsonPropertyName("parameters")]
        public SmartThingsInstanceParametersModel? Parameters { get; init; }
    }
}
