using AlisaToMQTTServer.Commands;
using AlisaToMQTTServer.Commands.DeInitialize;

namespace AlisaToMQTTServer.Initializer;

public sealed class AppDeInitializer : IAppDeInitializer
{
    private readonly ICommandsExecutor _commandsExecutor;
    private readonly DeInitializeHttpServerCommand _deInitializeHttpServerCommand;

    public AppDeInitializer(ICommandsExecutor commandsExecutor,
                            DeInitializeHttpServerCommand deInitializeHttpServerCommand)
    {
        _commandsExecutor = commandsExecutor;
        _deInitializeHttpServerCommand = deInitializeHttpServerCommand;
    }

    public void DeInitializer()
    {
        AddCommand(_deInitializeHttpServerCommand);

        Execute();
    }

    private void AddCommand(ICommand command)
    {
        _commandsExecutor.AddCommand(command);
    }

    private void Execute()
    {
        _commandsExecutor.Start();
    }
}

