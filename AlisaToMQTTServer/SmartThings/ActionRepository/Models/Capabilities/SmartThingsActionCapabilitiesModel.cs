using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.ActionRepository.Models.Results;
using AlisaToMQTTServer.SmartThings.Interface;

namespace AlisaToMQTTServer.SmartThings.ActionRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsActionCapabilitiesModel))]
public sealed class SmartThingsActionCapabilitiesModel : SmartThingsCapabilitiesModel
{
    [JsonInclude]
    [JsonPropertyName("state")]
    public SmartThingsResultModel? State { get; init; }
}

