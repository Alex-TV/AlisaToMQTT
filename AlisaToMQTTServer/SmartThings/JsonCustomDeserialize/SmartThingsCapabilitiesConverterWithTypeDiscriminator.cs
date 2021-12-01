using System.Text.Json;
using System.Text.Json.Serialization;
using AlisaToMQTTServer.SmartThings.Models;

namespace AlisaToMQTTServer.SmartThings.JsonCustomDeserialize
{
    public class SmartThingsCapabilitiesConverterWithTypeDiscriminator : JsonConverter<SmartThingsCapabilitiesModel>
    {
        public override bool CanConvert(Type typeToConvert) => typeof(SmartThingsCapabilitiesModel).IsAssignableFrom(typeToConvert);

        public override SmartThingsCapabilitiesModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Utf8JsonReader readerClone = reader;

            if (readerClone.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            readerClone.Read();

            if (readerClone.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            string? propertyName = readerClone.GetString();

            if (propertyName is not "type")
            {
                throw new JsonException();
            }

            readerClone.Read();

            if (readerClone.TokenType != JsonTokenType.String)
            {
                throw new JsonException();
            }

            var typeCapabilities = readerClone.GetString();

            if(string.IsNullOrEmpty(typeCapabilities))
            {
                throw new JsonException();
            }

            return CapabilitiesJsonSerializer.Deserialize(typeCapabilities, ref reader);
        }

        public override void Write(Utf8JsonWriter writer, SmartThingsCapabilitiesModel value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            CapabilitiesJsonSerializer.Serialize(writer, value);
            writer.WriteEndObject();
        }
    }
}
