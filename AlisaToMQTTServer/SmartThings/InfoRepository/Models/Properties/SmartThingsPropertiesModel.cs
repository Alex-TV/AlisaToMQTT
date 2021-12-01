using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Properties
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
