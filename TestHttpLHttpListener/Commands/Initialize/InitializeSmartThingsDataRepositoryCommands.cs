using TestHttpLHttpListener.SmartThings;

namespace TestHttpLHttpListener.Commands.Initialize
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
