using CommandLibrary.ShoppingCartExample.Commands.Common;

namespace CommandLibrary.ShoppingCartExample;

public class CommandManager
{
    private readonly Stack<ICommand> _commands = new();

    public void Invoke(ICommand command)
    {
        if (!command.CanExecute())
        {
            return;
        }

        _commands.Push(command);
        command.Execute();
    }

    public void Undo()
    {
        if (!_commands.Any())
        {
            return;
        }

        var command = _commands.Pop();
        command.Undo();
    }
}
