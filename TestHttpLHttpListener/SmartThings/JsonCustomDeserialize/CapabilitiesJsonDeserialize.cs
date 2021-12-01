
using System.Text.Json;
using TestHttpLHttpListener.SmartThings.Models;

namespace TestHttpLHttpListener.SmartThings.JsonCustomDeserialize
{
    public static class CapabilitiesJsonSerializer
    {
        private delegate SmartThingsCapabilitiesModel? DeserializeDelegate(ref Utf8JsonReader reader);

        private static Dictionary<string, DeserializeDelegate> _deserializers = 
            new Dictionary<string, DeserializeDelegate> {
            {"devices.capabilities.range", (ref Utf8JsonReader reader)=> JsonSerializer.Deserialize<SmartThingsCapabilitiesRangeModel>(ref reader)},
            {"devices.capabilities.color_setting", (ref Utf8JsonReader reader)=> JsonSerializer.Deserialize<SmartThingsCapabilitiesColorSettingModel>(ref reader)},
            {"devices.capabilities.on_off", (ref Utf8JsonReader reader)=> JsonSerializer.Deserialize<SmartThingsCapabilitiesOnOffModel>(ref reader)},
        };

        private static Dictionary<string, Action<Utf8JsonWriter, SmartThingsCapabilitiesModel>> _serializer =
            new Dictionary<string, Action<Utf8JsonWriter, SmartThingsCapabilitiesModel>>
        {
            {"devices.capabilities.range", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsCapabilitiesRangeModel)capabilitie)},
            {"devices.capabilities.color_setting", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsCapabilitiesColorSettingModel)capabilitie)},
            {"devices.capabilities.on_off", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsCapabilitiesOnOffModel)capabilitie)}
        };


        public static SmartThingsCapabilitiesModel? Deserialize(string typeCapabilities, ref Utf8JsonReader reader)
        {
            if (_deserializers.TryGetValue(typeCapabilities, out var deserializeDelegate))
            {
                return deserializeDelegate(ref reader);
            }
            throw new JsonException();
        }

        public static void Serialize(Utf8JsonWriter writer, SmartThingsCapabilitiesModel value)
        {
            if(string.IsNullOrEmpty(value.CapabilitiesType))
            {
                throw new JsonException();
            }

            if (_serializer.TryGetValue(value.CapabilitiesType, out var serializer))
            {
                serializer.Invoke(writer, value);
            }
            else
            {
                throw new JsonException();
            }
        }
    }
}
