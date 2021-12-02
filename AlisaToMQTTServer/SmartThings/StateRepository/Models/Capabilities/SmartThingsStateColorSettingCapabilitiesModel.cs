using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.StateRepository.Models.Statesl;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsStateColorSettingCapabilitiesModel))]
public sealed class SmartThingsStateColorSettingCapabilitiesModel : SmartThingsStateCapabilitiesModel
{
    [JsonInclude]
    [JsonPropertyName("state")]
    public SmartThingsStateColorSceneHVSModel? State { get; init; }
}

