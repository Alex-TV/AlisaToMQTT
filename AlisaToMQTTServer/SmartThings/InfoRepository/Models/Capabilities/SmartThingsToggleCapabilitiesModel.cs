using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsOnOffCapabilitiesModel))]
public sealed class SmartThingsToggleCapabilitiesModel : SmartThingsInfoCapabilitiesModel
{
    //"devices.capabilities.toggle"
    [JsonInclude]
    [JsonPropertyName("parameters")]
    public SmartThingsInstanceParametersModel? Parameters { get; init; }
}

