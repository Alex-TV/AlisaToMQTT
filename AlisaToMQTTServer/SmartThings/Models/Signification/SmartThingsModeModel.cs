using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsModeModel))]
    public class SmartThingsModeModel
    {
        [JsonInclude]
        [JsonPropertyName("value")]
        public string? ModeValue { get; init; }
    }
}
