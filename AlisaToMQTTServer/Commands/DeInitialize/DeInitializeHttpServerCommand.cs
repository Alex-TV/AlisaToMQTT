using AlisaToMQTTServer.Server;

namespace AlisaToMQTTServer.Commands.DeInitialize;

public sealed class DeInitializeHttpServerCommand : Command
{
    private readonly IHttpServer _httpServer;

    public DeInitializeHttpServerCommand(IHttpServer httpServer)
    {
        _httpServer = httpServer;
    }

    public override void Execute()
    {
        _httpServer.Stop();
        OnCompleted();
    }
}

