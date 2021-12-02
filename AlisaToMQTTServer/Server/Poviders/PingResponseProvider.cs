using System.Net;

namespace AlisaToMQTTServer.Server.Poviders;

public sealed class PingResponseProvider : IResponseProvider
{
    private readonly HttpListenerRequest _request;

    public PingResponseProvider(HttpListenerRequest request)
    {
        _request = request;
    }

    public void Build() { }
}

