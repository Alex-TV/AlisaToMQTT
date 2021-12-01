using Microsoft.Extensions.DependencyInjection;
using AlisaToMQTTServer.Commands;
using AlisaToMQTTServer.Commands.DeInitialize;
using AlisaToMQTTServer.Commands.Initialize;

namespace AlisaToMQTTServer.Server.Initializer.Commands.Bulder
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
