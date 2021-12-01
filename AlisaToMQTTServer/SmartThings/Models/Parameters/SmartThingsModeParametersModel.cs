using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsModeParametersModel))]
    public class SmartThingsModeParametersModel : SmartThingsInstanceParametersModel
    {
        [JsonInclude]
        [JsonPropertyName("modes")]
        public List<SmartThingsModeModel>? Modes { get; init; }
    }
}
