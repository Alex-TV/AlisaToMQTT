using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters;

[JsonSerializable(typeof(SmartThingsRangeParametersModel))]
public sealed class SmartThingsRangeParametersModel : SmartThingsInstanceParametersModel
{
    [JsonInclude]
    [JsonPropertyName("random_access")]
    public bool RandomAccess { get; init; }
    [JsonInclude]
    [JsonPropertyName("range")]
    public SmartThingsRangeModel? Range { get; init; }
    [JsonInclude]
    [JsonPropertyName("unit")]
    public string? Unit { get; init; }
}

