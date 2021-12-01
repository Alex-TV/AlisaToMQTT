using Microsoft.Extensions.DependencyInjection;
using TestHttpLHttpListener.Commands;
using TestHttpLHttpListener.Commands.DeInitialize;
using TestHttpLHttpListener.Commands.Initialize;

namespace TestHttpLHttpListener.Server.Initializer.Commands.Bulder
{
    public static class CommandsBuilder
    {
        public static void Build(ServiceCollection services)
        {
            services.AddSingleton<ICommandsExecutor, CommandsExecutor>();
            services.AddSingleton<InitializeHttpServerCommand>();
            services.AddSingleton<InitializeSmartThingsDataRepositoryCommands>();
            services.AddSingleton<DeInitializeHttpServerCommand>();
        }
    }
}
