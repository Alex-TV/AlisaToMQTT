using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    //[JsonSerializable(typeof(SmartThingsModel))]
    public class SmartThingsModel
    {
        [JsonInclude]
        [JsonPropertyName("id")]
        public string? Id { get; init; }
        [JsonInclude]
        [JsonPropertyName("name")]
        public string? Name { get; init; }
        [JsonInclude]
        [JsonPropertyName("description")]
        public string? Description { get; init; }
        [JsonInclude]
        [JsonPropertyName("room")]
        public string? Room { get; init; }
        [JsonInclude]
        [JsonPropertyName("type")]
        public string? Type { get; init; }
        [JsonInclude]
        [JsonPropertyName("custom_data")]
        public SmartThingsMqttContainerModel? CustomData { get; init; }
        [JsonInclude]
        [JsonPropertyName("capabilities")]
        public List<SmartThingsCapabilitiesModel>? Capabilities { get; init; }
        [JsonInclude]
        [JsonPropertyName("device_info")]
        public SmartThingsDeviceInfoModel? DeviceInfo { get; init; }
    }
}
