using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models;

[JsonSerializable(typeof(SmartThingsMqttContainerModel))]
public sealed class SmartThingsMqttContainerModel
{
    [JsonInclude]
    [JsonPropertyName("mqtt")]
    public List<SmartThingsMqttModel> Container { get; }

    public SmartThingsMqttContainerModel(List<SmartThingsMqttModel> container)
    {
        Container = container;
    }
}

