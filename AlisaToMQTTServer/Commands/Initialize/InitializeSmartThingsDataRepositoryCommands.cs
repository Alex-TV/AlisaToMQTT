using AlisaToMQTTServer.SmartThings.InfoRepository;

namespace AlisaToMQTTServer.Commands.Initialize
{
    public class InitializeSmartThingsDataRepositoryCommands : Command
    {
        private readonly ISmartThingsDataInfoRepository _thingsDataRepository;

        public InitializeSmartThingsDataRepositoryCommands(ISmartThingsDataInfoRepository thingsDataRepository)
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
