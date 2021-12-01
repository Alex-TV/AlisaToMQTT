using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities
{
    [JsonSerializable(typeof(SmartThingsOnOffCapabilitiesModel))]
    public class SmartThingsOnOffCapabilitiesModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.on_off",
    }
}
