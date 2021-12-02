using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification;

[JsonSerializable(typeof(SmartThingsRangeModel))]
public sealed class SmartThingsTemperatureKModel
{
    [JsonInclude]
    [JsonPropertyName("max")]
    public int Max { get; init; }
    [JsonInclude]
    [JsonPropertyName("min")]
    public int Min { get; init; }

}

