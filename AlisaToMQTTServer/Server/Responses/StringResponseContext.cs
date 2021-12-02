
namespace AlisaToMQTTServer.Server.Responses;

public sealed class StringResponseContext : BaseResponseContext
{
    public StringResponseContext(string message) : base(200, "application/json", message) { }
}
