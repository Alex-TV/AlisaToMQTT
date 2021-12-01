using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities
{
    [JsonSerializable(typeof(SmartThingsModeCapabilitiesModel))]
    public class SmartThingsModeCapabilitiesModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.mode"
        [JsonInclude]
        [JsonPropertyName("parameters")]
        public SmartThingsModeParametersModel? Parameters { get; init; }
    }
}
