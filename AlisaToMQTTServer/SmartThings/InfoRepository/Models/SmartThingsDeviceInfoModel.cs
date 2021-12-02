using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models;

[JsonSerializable(typeof(SmartThingsDeviceInfoModel))]
public sealed class SmartThingsDeviceInfoModel
{
    [JsonInclude]
    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; init; }
    [JsonInclude]
    [JsonPropertyName("model")]
    public string? Model { get; init; }
    [JsonInclude]
    [JsonPropertyName("hw_version")]
    public string? HwVersion { get; init; }
    [JsonInclude]
    [JsonPropertyName("sw_version")]
    public string? SwVersion { get; init; }
}

