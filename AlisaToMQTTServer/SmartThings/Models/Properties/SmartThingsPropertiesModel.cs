using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsPropertiesModel))]
    public class SmartThingsPropertiesModel
    {
        [JsonInclude]
        [JsonPropertyName("type")]
        public string? PropertiesType { get; init; }
        [JsonInclude]
        [JsonPropertyName("retrievable")]
        public bool Retrievable { get; init; }
        [JsonInclude]
        [JsonPropertyName("reportable")]
        public bool Reportable { get; init; }
        [JsonInclude]
        [JsonPropertyName("parameters")]
        public SmartThingFloatModel? Parameters { get; init; }
    }
}
