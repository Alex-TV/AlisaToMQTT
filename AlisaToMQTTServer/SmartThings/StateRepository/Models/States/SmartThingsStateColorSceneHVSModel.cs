using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models.Statesl;

[JsonSerializable(typeof(SmartThingsStateColorSceneHVSModel))]
public sealed class SmartThingsStateColorSceneHVSModel : SmartThingsStateModel
{
    [JsonInclude]
    [JsonPropertyName("value")]
    public SmartThingsStateColorSceneHVSModel? StateValue { get; init; }
}
