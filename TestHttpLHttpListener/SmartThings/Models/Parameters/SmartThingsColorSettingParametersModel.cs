using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
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
    }
}
