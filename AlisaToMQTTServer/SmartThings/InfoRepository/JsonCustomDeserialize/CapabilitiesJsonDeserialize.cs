using System.Text.Json;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.JsonCustomDeserialize;

public static class InfoCapabilitiesJsonSerializer
{
    private delegate SmartThingsInfoCapabilitiesModel? DeserializeDelegate(ref Utf8JsonReader reader);

    private static Dictionary<string, DeserializeDelegate> _deserializers =
        new Dictionary<string, DeserializeDelegate> {
            {"devices.capabilities.range", (ref Utf8JsonReader reader) => JsonSerializer.Deserialize<SmartThingsInfoCapabilitiesModel>(ref reader)},
            {"devices.capabilities.color_setting", (ref Utf8JsonReader reader) => JsonSerializer.Deserialize<SmartThingsInfoCapabilitiesModel>(ref reader)},
            {"devices.capabilities.on_off", (ref Utf8JsonReader reader) => JsonSerializer.Deserialize<SmartThingsInfoCapabilitiesModel>(ref reader)},
            {"devices.capabilities.toggle", (ref Utf8JsonReader reader) => JsonSerializer.Deserialize<SmartThingsInfoCapabilitiesModel>(ref reader)},
            {"devices.capabilities.mode", (ref Utf8JsonReader reader) => JsonSerializer.Deserialize<SmartThingsInfoCapabilitiesModel>(ref reader)},
    };

    private static Dictionary<string, Action<Utf8JsonWriter, SmartThingsInfoCapabilitiesModel>> _serializer =
        new Dictionary<string, Action<Utf8JsonWriter, SmartThingsInfoCapabilitiesModel>>
    {
            {"devices.capabilities.range", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsRangeCapabilitiesModel)capabilitie)},
            {"devices.capabilities.color_setting", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsColorSettingCapabilitiesModel)capabilitie)},
            {"devices.capabilities.on_off", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsOnOffCapabilitiesModel)capabilitie)},
            {"devices.capabilities.toggle", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsToggleCapabilitiesModel)capabilitie)},
            {"devices.capabilities.mode", (writer,capabilitie) => JsonSerializer.Serialize(writer, (SmartThingsModeCapabilitiesModel)capabilitie)},
    };


    public static SmartThingsInfoCapabilitiesModel? Deserialize(string typeCapabilities, ref Utf8JsonReader reader)
    {
        if (_deserializers.TryGetValue(typeCapabilities, out var deserializeDelegate))
        {
            return deserializeDelegate(ref reader);
        }
        throw new JsonException();
    }

    public static void Serialize(Utf8JsonWriter writer, SmartThingsInfoCapabilitiesModel value)
    {
        if (string.IsNullOrEmpty(value.CapabilitiesType))
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

