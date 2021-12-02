using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.ActionRepository.Models.Capabilities;

namespace AlisaToMQTTServer.SmartThings.ActionRepository;

[JsonSerializable(typeof(SmartThingsActionDeviceModel))]
public sealed class SmartThingsActionDeviceModel
{
    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    [JsonInclude]
    [JsonPropertyName("capabilities")]
    public List<SmartThingsActionCapabilitiesModel>? Capabilities { get; init; }
}

