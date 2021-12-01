using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsInstanceParametersModel))]
    public class SmartThingsInstanceParametersModel
    {
        [JsonInclude]
        [JsonPropertyName("instance")]
        public string? Instance { get; init; }
    }
}
