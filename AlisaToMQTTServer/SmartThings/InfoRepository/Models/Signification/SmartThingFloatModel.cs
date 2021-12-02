using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification;

[JsonSerializable(typeof(SmartThingFloatModel))]
public sealed class SmartThingFloatModel
{
    [JsonInclude]
    [JsonPropertyName("instance")]
    public string? InstanceName { get; init; }
    [JsonInclude]
    [JsonPropertyName("unit")]
    public string? Unit { get; init; }
}

