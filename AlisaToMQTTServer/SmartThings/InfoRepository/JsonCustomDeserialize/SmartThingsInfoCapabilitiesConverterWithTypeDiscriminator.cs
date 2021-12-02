using System.Text.Json;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;
using AlisaToMQTTServer.SmartThings.Interface;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.JsonCustomDeserialize;

public sealed class SmartThingsInfoCapabilitiesConverterWithTypeDiscriminator :
    SmartThingsCapabilitiesConverterWithTypeDiscriminator<SmartThingsInfoCapabilitiesModel>
{
    protected override SmartThingsInfoCapabilitiesModel? CapabilitiesDeserialize(string typeCapabilities, ref Utf8JsonReader reader)
    {
        return InfoCapabilitiesJsonSerializer.Deserialize(typeCapabilities, ref reader);
    }

    protected override void CapabilitiesSerialize(SmartThingsInfoCapabilitiesModel value, Utf8JsonWriter writer)
    {
        InfoCapabilitiesJsonSerializer.Serialize(writer, value);
    }
}

