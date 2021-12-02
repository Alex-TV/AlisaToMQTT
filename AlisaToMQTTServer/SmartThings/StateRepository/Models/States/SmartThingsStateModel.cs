using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models.Statesl;

[JsonSerializable(typeof(SmartThingsStateModel))]
public abstract class SmartThingsStateModel
{
    [JsonInclude]
    [JsonPropertyName("instance")]
    public string? Instance { get; init; }
}
