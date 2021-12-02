using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsModeCapabilitiesModel))]
public sealed class SmartThingsModeCapabilitiesModel : SmartThingsInfoCapabilitiesModel
{
    //"devices.capabilities.mode"
    [JsonInclude]
    [JsonPropertyName("parameters")]
    public SmartThingsModeParametersModel? Parameters { get; init; }
}

