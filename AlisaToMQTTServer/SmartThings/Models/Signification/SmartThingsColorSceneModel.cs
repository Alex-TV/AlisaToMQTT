using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsColorSceneModel))]
    public class SmartThingsColorSceneModel
    {
        [JsonInclude]
        [JsonPropertyName("id")]
        public string? Id { get; init; }
    }
}
