using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters
{
    [JsonSerializable(typeof(SmartThingsInstanceParametersModel))]
    public class SmartThingsInstanceParametersModel
    {
        [JsonInclude]
        [JsonPropertyName("instance")]
        public string? Instance { get; init; }
    }
}
