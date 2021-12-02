using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models;
using AlisaToMQTTServer.SmartThings.StateRepository.Models.Capabilities;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models;

[JsonSerializable(typeof(SmartThingsDeviceModel))]
public sealed class SmartThingsDeviceModel
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
    [JsonPropertyName("type")]
    public string? ThingsType { get; init; }
    [JsonInclude]
    [JsonPropertyName("custom_data")]
    public SmartThingsMqttContainerModel? CustomData { get; init; }
    [JsonInclude]
    [JsonPropertyName("capabilities")]
    public List<SmartThingsStateCapabilitiesModel>? Capabilities { get; init; }
}

