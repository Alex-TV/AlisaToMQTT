﻿using System.Text.Json.Serialization;

namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsRangeModel))]
    public class SmartThingsTemperatureKModel
    {
        [JsonInclude]
        [JsonPropertyName("max")]
        public int Max { get; init; }
        [JsonInclude]
        [JsonPropertyName("min")]
        public int Min { get; init; }

    }
}
