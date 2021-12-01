using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsCapabilitiesModel))]
    public abstract class SmartThingsCapabilitiesModel
    {
        [JsonInclude]
        [JsonPropertyName("type")]
        public string? CapabilitiesType { get; init; }
        [JsonInclude]
        [JsonPropertyName("retrievable")]
        public bool Retrievable { get; init; }
    }
}
