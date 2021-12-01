using AlisaToMQTTServer.SmartThings;

namespace AlisaToMQTTServer.Commands.Initialize
{
    public class InitializeSmartThingsDataRepositoryCommands : Command
    {
        private readonly ISmartThingsDataRepository _thingsDataRepository;

        public InitializeSmartThingsDataRepositoryCommands(ISmartThingsDataRepository thingsDataRepository)
        {
            _thingsDataRepository = thingsDataRepository;
        }

        public override void Execute()
        {
            _thingsDataRepository.Initialize();
            OnCompleted();
        }
    }
}
