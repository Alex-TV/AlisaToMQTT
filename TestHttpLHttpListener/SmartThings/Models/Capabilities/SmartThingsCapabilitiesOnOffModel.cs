using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsCapabilitiesOnOffModel))]
    public class SmartThingsCapabilitiesOnOffModel : SmartThingsCapabilitiesModel
    {
        //"devices.capabilities.on_off",
    }
}
