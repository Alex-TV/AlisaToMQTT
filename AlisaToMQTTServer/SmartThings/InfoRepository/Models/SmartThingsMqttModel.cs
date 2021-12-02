using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models;

[JsonSerializable(typeof(SmartThingsMqttModel))]
public sealed class SmartThingsMqttModel
{
    [JsonInclude]
    [JsonPropertyName("type")]
    public string MqttType { get; }
    [JsonInclude]
    [JsonPropertyName("set")]
    public string MqttSet { get; }
    [JsonInclude]
    [JsonPropertyName("stat")]
    public string MqttStat { get; }

    public SmartThingsMqttModel(string mqttType, string mqttSet, string mqttStat)
    {
        MqttType = mqttType;
        MqttSet = mqttSet;
        MqttStat = mqttStat;
    }
}

