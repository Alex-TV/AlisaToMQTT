using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification
{
    [JsonSerializable(typeof(SmartThingsColorSceneModel))]
    public class SmartThingsColorSceneModel
    {
        [JsonInclude]
        [JsonPropertyName("id")]
        public string? Id { get; init; }
    }
}
