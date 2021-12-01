
namespace TestHttpLHttpListener.Commands
{
    public interface ICommandsExecutor
    {
        event EventHandler CommandCompleted;
        event EventHandler<ICommand> CommandFailed;
        event EventHandler AllCompleted;

        int CommandsCount { get; }
        float SecondsSinceStartExecution { get; }

        void AddCommand(ICommand command);
        void Start(int delayBetweenCommands = 0);
        void Stop();
    }
}
