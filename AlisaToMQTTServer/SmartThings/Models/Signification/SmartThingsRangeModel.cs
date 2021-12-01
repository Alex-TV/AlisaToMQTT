using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsRangeModel))]
    public class SmartThingsRangeModel
    {
        [JsonInclude]
        [JsonPropertyName("max")]
        public int Max { get; init; }
        [JsonInclude]
        [JsonPropertyName("min")]
        public int Min { get; init; }
        [JsonInclude]
        [JsonPropertyName("precision")]
        public int Precision { get; init; }
    }
}
