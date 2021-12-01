using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingFloatModel))]
    public class SmartThingFloatModel
    {
        [JsonInclude]
        [JsonPropertyName("instance")]
        public string? InstanceName { get; init; }
        [JsonInclude]
        [JsonPropertyName("unit")]
        public string? Unit { get; init; }
    }
}
