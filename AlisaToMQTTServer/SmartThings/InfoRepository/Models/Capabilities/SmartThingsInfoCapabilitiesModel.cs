using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.Interface;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsCapabilitiesModel))]
public abstract class SmartThingsInfoCapabilitiesModel : SmartThingsCapabilitiesModel
{
    [JsonInclude]
    [JsonPropertyName("retrievable")]
    public bool Retrievable { get; init; }
}

