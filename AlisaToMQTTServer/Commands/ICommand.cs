
namespace AlisaToMQTTServer.Commands;

public interface ICommand
{
    event EventHandler Completed;
    event EventHandler Failed;

    bool IsCompleted { get; }

    void Execute();
    void Stop();
}

