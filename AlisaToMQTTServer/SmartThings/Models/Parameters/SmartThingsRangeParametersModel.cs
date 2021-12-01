using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsRangeParametersModel))]
    public class SmartThingsRangeParametersModel : SmartThingsInstanceParametersModel
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
}
