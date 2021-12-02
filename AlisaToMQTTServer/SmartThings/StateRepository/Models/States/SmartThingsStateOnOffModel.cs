using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models.Statesl;

[JsonSerializable(typeof(SmartThingsStateOnOffModel))]
public sealed class SmartThingsStateOnOffModel : SmartThingsStateModel
{
    [JsonInclude]
    [JsonPropertyName("value")]
    public bool StateValue { get; init; }
}