using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.StateRepository.Models.Statesl;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsStateOnOffCapabilitiesModel))]
public sealed class SmartThingsStateOnOffCapabilitiesModel : SmartThingsStateCapabilitiesModel
{
    [JsonInclude]
    [JsonPropertyName("state")]
    public SmartThingsStateOnOffModel? State { get; init; }
}

