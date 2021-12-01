using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsCapabilitiesRangeModel))]
    public class SmartThingsCapabilitiesRangeModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.range",
        [JsonInclude]
        [JsonPropertyName("parameters")]
        public SmartThingsRangeParametersModel? Parameters { get; init; }
    }
}
