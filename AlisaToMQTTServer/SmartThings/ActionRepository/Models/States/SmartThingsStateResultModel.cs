using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.ActionRepository.Models.States;

[JsonSerializable(typeof(SmartThingsStateResultModel))]
public sealed class SmartThingsStateResultModel
{
    [JsonInclude]
    [JsonPropertyName("status")]
    public string? Status { get; init; } //"ERROR", "DONE"
    [JsonInclude]
    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; init; }//"INVALID_ACTION"
    [JsonInclude]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }  //"the human readable error message"
}

