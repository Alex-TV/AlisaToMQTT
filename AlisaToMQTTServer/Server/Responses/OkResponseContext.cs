
namespace AlisaToMQTTServer.Server.Responses;

public sealed class OkResponseContext : BaseResponseContext
{
    public OkResponseContext() : base(200, string.Empty, string.Empty) { }
}

