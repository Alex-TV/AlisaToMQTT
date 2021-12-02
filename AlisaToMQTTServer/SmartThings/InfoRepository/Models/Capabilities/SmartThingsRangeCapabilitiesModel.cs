using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsRangeCapabilitiesModel))]
public sealed class SmartThingsRangeCapabilitiesModel : SmartThingsInfoCapabilitiesModel
{
    //"devices.capabilities.range",
    [JsonInclude]
    [JsonPropertyName("parameters")]
    public SmartThingsRangeParametersModel? Parameters { get; init; }
}

