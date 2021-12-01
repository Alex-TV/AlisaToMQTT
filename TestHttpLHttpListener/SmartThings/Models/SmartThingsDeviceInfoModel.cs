using System.Text.Json.Serialization;


namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsDeviceInfoModel))]
    public class SmartThingsDeviceInfoModel
    {
        [JsonInclude]
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; }
        [JsonInclude]
        [JsonPropertyName("model")]
        public string Model { get; }
        [JsonInclude]
        [JsonPropertyName("hw_version")]
        public string HwVersion { get; }
        [JsonInclude]
        [JsonPropertyName("sw_version")]
        public string SwVersion { get; }

        public SmartThingsDeviceInfoModel(string manufacturer, string model, string hwVersion, string swVersion)
        {
            Manufacturer = manufacturer;
            Model = model;
            HwVersion = hwVersion;
            SwVersion = swVersion;
        }

    }
}
