using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification;

[JsonSerializable(typeof(SmartThingsModeModel))]
public sealed class SmartThingsModeModel
{
    [JsonInclude]
    [JsonPropertyName("value")]
    public string? ModeValue { get; init; }
}

