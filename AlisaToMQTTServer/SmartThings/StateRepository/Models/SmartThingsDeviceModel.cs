using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.StateRepository.Models.Capabilities;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models;

[JsonSerializable(typeof(SmartThingsDeviceModel))]
public sealed class SmartThingsDeviceModel
{
    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    [JsonInclude]
    [JsonPropertyName("capabilities")]
    public List<SmartThingsStateCapabilitiesModel>? Capabilities { get; init; }
    [JsonInclude]
    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; init; } //DEVICE_NOT_FOUND
    [JsonInclude]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }//the human readable error message
}

