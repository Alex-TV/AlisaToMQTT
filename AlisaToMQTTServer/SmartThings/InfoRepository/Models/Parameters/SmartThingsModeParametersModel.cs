using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.InfoRepository.Models.Signification;

namespace AlisaToMQTTServer.SmartThings.InfoRepository.Models.Parameters
{
    [JsonSerializable(typeof(SmartThingsModeParametersModel))]
    public class SmartThingsModeParametersModel : SmartThingsInstanceParametersModel
    {
        [JsonInclude]
        [JsonPropertyName("modes")]
        public List<SmartThingsModeModel>? Modes { get; init; }
    }
}
