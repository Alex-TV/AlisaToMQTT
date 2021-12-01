using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    public interface ISmartThingsParametersModel
    {

    }

    public interface ISmartThingsPropertiesModel
    {

    }

    [JsonSerializable(typeof(SmartThingsCapabilitiesModel))]
    public class SmartThingsCapabilitiesModel
    {
        [JsonInclude]
        [JsonPropertyName("type")]
        public string CapabilitiesType { get; }
        [JsonInclude]
        [JsonPropertyName("retrievable")]
        public bool Retrievable { get; }

        public ISmartThingsParametersModel Parameters { get; }

        public SmartThingsCapabilitiesModel(string capabilitiesType, bool retrievable)
        {
            CapabilitiesType = capabilitiesType;
            Retrievable = retrievable;
        }
    }

    [JsonSerializable(typeof(SmartThingsModel))]
    public class SmartThingsModel
    {
        [JsonInclude]
        [JsonPropertyName("id")]
        public string Id { get; }
        [JsonInclude]
        [JsonPropertyName("name")]
        public string Name { get; }
        [JsonInclude]
        [JsonPropertyName("description")]
        public string Description { get; }
        [JsonInclude]
        [JsonPropertyName("room")]
        public string Room { get; }
        [JsonInclude]
        [JsonPropertyName("type")]
        public string Type { get; }
        [JsonInclude]
        [JsonPropertyName("custom_data")]
        public SmartThingsMqttContainerModel CustomData { get; }
        [JsonInclude]
        [JsonPropertyName("capabilities")]
        public List<SmartThingsCapabilitiesModel> Capabilities { get; }

        public ISmartThingsPropertiesModel Properties { get; }
        [JsonInclude]
        [JsonPropertyName("device_info")]
        public SmartThingsDeviceInfoModel DeviceInfo { get; }

        public SmartThingsModel(string id,
                                string name,
                                string description,
                                string room,
                                string type,
                                SmartThingsMqttContainerModel customData,
                                List<SmartThingsCapabilitiesModel> capabilities,
                                ISmartThingsPropertiesModel properties,
                                SmartThingsDeviceInfoModel deviceInfo)
        {
            Id = id;
            Name = name;
            Description = description;
            Room = room;
            Type = type;
            CustomData = customData;
            Capabilities = capabilities;
            Properties = properties;
            DeviceInfo = deviceInfo;
        }
    }
}
