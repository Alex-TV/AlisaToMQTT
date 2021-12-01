using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
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
