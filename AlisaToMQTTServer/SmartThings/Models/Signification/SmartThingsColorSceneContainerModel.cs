using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsColorSceneContainerModel))]
    public class SmartThingsColorSceneContainerModel
    {
        [JsonInclude]
        [JsonPropertyName("scenes")]
        public List<SmartThingsColorSceneModel>? Scenes { get; init; }
    }
}
