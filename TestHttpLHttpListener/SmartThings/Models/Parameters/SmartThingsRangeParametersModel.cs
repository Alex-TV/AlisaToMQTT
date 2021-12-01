using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsRangeParametersModel))]
    public class SmartThingsRangeParametersModel
    {
        [JsonInclude]
        [JsonPropertyName("instance")]
        public string? Instance { get; init; }
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
