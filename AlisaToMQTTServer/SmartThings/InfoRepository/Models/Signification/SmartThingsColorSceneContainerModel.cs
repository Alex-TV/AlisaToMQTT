using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification;

[JsonSerializable(typeof(SmartThingsColorSceneContainerModel))]
public sealed class SmartThingsColorSceneContainerModel
{
    [JsonInclude]
    [JsonPropertyName("scenes")]
    public List<SmartThingsColorSceneModel>? Scenes { get; init; }
}

