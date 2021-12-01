using TestHttpLHttpListener.Server;

namespace TestHttpLHttpListener.Commands.Initialize
{
    public class InitializeHttpServerCommand : Command
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
}
