﻿using TestHttpLHttpListener.Commands;
using TestHttpLHttpListener.Commands.Initialize;

namespace TestHttpLHttpListener.Server.Initializer
{
    public class AppInitializer : IAppInitializer
    {
        private readonly ICommandsExecutor _commandsExecutor;
        private readonly InitializeHttpServerCommand _httpServerCommand;
        private readonly InitializeSmartThingsDataRepositoryCommands _thingsDataRepositoryCommands;

        public AppInitializer(ICommandsExecutor commandsExecutor,
                              InitializeHttpServerCommand httpServerCommand,
                              InitializeSmartThingsDataRepositoryCommands thingsDataRepositoryCommands)
        {
            _commandsExecutor = commandsExecutor;
            _httpServerCommand = httpServerCommand;
            _thingsDataRepositoryCommands = thingsDataRepositoryCommands;
        }

        public void Initialize()
        {
            AddCommand(_httpServerCommand);
            AddCommand(_thingsDataRepositoryCommands);  

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
}
