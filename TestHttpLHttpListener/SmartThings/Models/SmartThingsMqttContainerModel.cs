﻿using System.Text.Json.Serialization;


namespace TestHttpLHttpListener.SmartThings.Models
{
    [JsonSerializable(typeof(SmartThingsMqttContainerModel))]
    public class SmartThingsMqttContainerModel
    {
        [JsonInclude]
        [JsonPropertyName("mqtt")]
        public List<SmartThingsMqttModel> Container { get; }

        public SmartThingsMqttContainerModel(List<SmartThingsMqttModel> container)
        {
            Container = container;
        }
    }
}
