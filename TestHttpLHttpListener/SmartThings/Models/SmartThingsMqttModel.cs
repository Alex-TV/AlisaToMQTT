using System.Text.Json.Serialization;


namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsMqttModel))]
    public class SmartThingsMqttModel
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
}
