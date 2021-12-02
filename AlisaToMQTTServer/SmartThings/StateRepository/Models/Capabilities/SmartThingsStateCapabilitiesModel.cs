using AlisaToMQTTServer.SmartThings.Interface;
using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.StateRepository.Models.Capabilities;

[JsonSerializable(typeof(SmartThingsStateCapabilitiesModel))]
public abstract class SmartThingsStateCapabilitiesModel : SmartThingsCapabilitiesModel { }

