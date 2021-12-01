using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsColorSettingParametersModel))]
    public class SmartThingsColorSettingParametersModel
    {
        [JsonInclude]
        [JsonPropertyName("color_model")]
        public string? ColorModel { get; init; }

        [JsonInclude]
        [JsonPropertyName("temperature_k")]
        public SmartThingsTemperatureKModel? Temperaturek { get; init; }

        [JsonInclude]
        [JsonPropertyName("color_scene")]
        public SmartThingsColorSceneContainerModel? ColorScene { get; init; }
    }
}
