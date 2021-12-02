using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsOnOffCapabilitiesModel))]
public sealed class SmartThingsOnOffCapabilitiesModel : SmartThingsInfoCapabilitiesModel
{
    //"devices.capabilities.on_off",
}

