using System;
using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models.Signification;

[JsonSerializable(typeof(SmartThingsColorSceneHVSModel))]
public class SmartThingsColorSceneHVSModel
{
    [JsonInclude]
    [JsonPropertyName("retrievable")]
    public int Hue { get; init; }
    [JsonInclude]
    [JsonPropertyName("retrievable")]
    public int Saturation { get; init; }
    [JsonInclude]
    [JsonPropertyName("retrievable")]
    public int Brightness { get; init; }
}

