using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.ActionRepository.Models.States;

namespace AlisaToMQTTServer.SmartThings.ActionRepository.Models.Results;

[JsonSerializable(typeof(SmartThingsResultModel))]
public sealed class SmartThingsResultModel
{
    [JsonInclude]
    [JsonPropertyName("instance")]
    public string? Instance { get; init; }
    [JsonInclude]
    [JsonPropertyName("action_result")]
    public SmartThingsStateResultModel? ActionResult { get; init; }
}

