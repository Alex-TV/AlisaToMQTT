using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities
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
