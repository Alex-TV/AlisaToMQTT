using AlisaToMQTTServer.Server;

namespace AlisaToMQTTServer.Commands.Initialize;

public sealed class InitializeHttpServerCommand : Command
{
    private readonly IHttpServer _httpServer;

    public InitializeHttpServerCommand(IHttpServer httpServer)
    {
        _httpServer = httpServer;
    }

    public override void Execute()
    {
        _httpServer.Start();
        OnCompleted();
    }
}

