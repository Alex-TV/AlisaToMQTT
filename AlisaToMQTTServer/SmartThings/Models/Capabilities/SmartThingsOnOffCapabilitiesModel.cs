using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsOnOffCapabilitiesModel))]
    public class SmartThingsOnOffCapabilitiesModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.on_off",
    }
}
