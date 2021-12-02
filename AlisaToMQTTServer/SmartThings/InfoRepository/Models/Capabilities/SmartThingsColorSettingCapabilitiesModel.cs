using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsRangeCapabilitiesModel))]
public sealed class SmartThingsColorSettingCapabilitiesModel : SmartThingsInfoCapabilitiesModel
{
    //"devices.capabilities.color_setting"
    [JsonInclude]
    [JsonPropertyName("parameters")]
    public SmartThingsColorSettingParametersModel? Parameters { get; init; }
}

