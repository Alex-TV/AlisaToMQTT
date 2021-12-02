using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Interface;

[JsonSerializable(typeof(SmartThingsCapabilitiesModel))]
public abstract class SmartThingsCapabilitiesModel
{
    [JsonInclude]
    [JsonPropertyName("type")]
    public string? CapabilitiesType { get; init; }

}

