using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Properties;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models;

[JsonSerializable(typeof(SmartThingsInfoModel))]
public sealed class SmartThingsInfoModel
{
    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    [JsonInclude]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
    [JsonInclude]
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    [JsonInclude]
    [JsonPropertyName("room")]
    public string? Room { get; init; }
    [JsonInclude]
    [JsonPropertyName("type")]
    public string? ThingsType { get; init; }
    [JsonInclude]
    [JsonPropertyName("custom_data")]
    public SmartThingsMqttContainerModel? CustomData { get; init; }
    [JsonInclude]
    [JsonPropertyName("capabilities")]
    public List<SmartThingsInfoCapabilitiesModel>? Capabilities { get; init; }
    [JsonInclude]
    [JsonPropertyName("properties")]
    public List<SmartThingsPropertiesModel>? Properties { get; init; }
    [JsonInclude]
    [JsonPropertyName("device_info")]
    public SmartThingsDeviceInfoModel? DeviceInfo { get; init; }
}

