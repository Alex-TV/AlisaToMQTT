using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlisaToMQTTServer.SmartThings.Interface;

public abstract class SmartThingsCapabilitiesConverterWithTypeDiscriminator<T> : JsonConverter<T>
{
    protected abstract T? CapabilitiesDeserialize(string typeCapabilities, ref Utf8JsonReader reader);
    protected abstract void CapabilitiesSerialize(T value, Utf8JsonWriter writer);

    public override bool CanConvert(Type typeToConvert) => typeof(T).IsAssignableFrom(typeToConvert);

    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

        if (string.IsNullOrEmpty(typeCapabilities))
        {
            throw new JsonException();
        }

        return CapabilitiesDeserialize(typeCapabilities, ref reader);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        CapabilitiesSerialize(value, writer);
        writer.WriteEndObject();
    }
 
}
