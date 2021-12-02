using AlisaToMQTTServer.SmartThings.Interface;
using AlisaToMQTTServer.SmartThings.StateRepository.Models.Capabilities;
using System.Text.Json;

namespace AlisaToMQTTServer.SmartThings.StateRepository.JsonCustomDeserialize;

public sealed class SmartThingsStateCapabilitiesConverterWithTypeDiscriminator :
    SmartThingsCapabilitiesConverterWithTypeDiscriminator<SmartThingsStateCapabilitiesModel>
{
    protected override SmartThingsStateCapabilitiesModel? CapabilitiesDeserialize(string typeCapabilities, ref Utf8JsonReader reader)
    {
        return StateCapabilitiesJsonSerializer.Deserialize(typeCapabilities, ref reader);
    }

    protected override void CapabilitiesSerialize(SmartThingsStateCapabilitiesModel value, Utf8JsonWriter writer)
    {
        StateCapabilitiesJsonSerializer.Serialize(writer, value);
    }
}

