using System.Diagnostics;

namespace TestHttpLHttpListener.Commands
{
    public class CommandsExecutor : ICommandsExecutor
    {
        public event EventHandler CommandCompleted;
        public event EventHandler<ICommand> CommandFailed;
        public event EventHandler AllCompleted;

        private readonly Queue<ICommand> _commands = new Queue<ICommand>();
        private ICommand _currentCommand;

        private int _delayBetweenCommands;
        private Stopwatch _stopwatch;

        public int CommandsCount => _commands.Count;
        public float SecondsSinceStartExecution => _stopwatch?.ElapsedMilliseconds / 1000.0f ?? 0;

        public void AddCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        public void Start(int delayBetweenCommands = 0)
        {
            _stopwatch = Stopwatch.StartNew();
            _delayBetweenCommands = delayBetweenCommands;

            if (_commands.Count == 0)
            {
                Debug.WriteLine("Command queue is empty");
                return;
            }

            ExecuteNextCommand();
        }

        public void Stop()
        {
            _currentCommand.Completed -= HandleCommandCompleted;
            _currentCommand.Failed -= HandleCommandOnFailed;
            _currentCommand = null;

            _commands.Clear();
        }

        private async void HandleCommandCompleted(object sender, EventArgs args)
        {
            OnCommandCompleted();

            _commands.Dequeue();

            _currentCommand.Completed -= HandleCommandCompleted;
            _currentCommand.Failed -= HandleCommandOnFailed;
            _currentCommand = null;

            if (_commands.Count > 0)
            {
                await Task.Delay(_delayBetweenCommands);
                ExecuteNextCommand();
                return;
            }

            OnAllCompleted();
        }

        private void HandleCommandOnFailed(object sender, EventArgs args)
        {
            OnCommandFailed(sender as ICommand);

            _currentCommand.Completed -= HandleCommandCompleted;
            _currentCommand.Failed -= HandleCommandOnFailed;
        }

        private void ExecuteNextCommand()
        {
            _currentCommand = _commands.Peek();

            _currentCommand.Completed += HandleCommandCompleted;
            _currentCommand.Failed += HandleCommandOnFailed;
            _currentCommand.Execute();
        }

        private void OnAllCompleted()
        {
            AllCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void OnCommandCompleted()
        {
            CommandCompleted?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnCommandFailed(ICommand e)
        {
            CommandFailed?.Invoke(this, e);
        }
    }
}
