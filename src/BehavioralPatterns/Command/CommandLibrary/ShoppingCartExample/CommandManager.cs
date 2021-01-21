using System.Collections.Generic;
using CommandLibrary.ShoppingCartExample.Commands.Common;

namespace CommandLibrary.ShoppingCartExample
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                _commands.Push(command);
                command.Execute();
            }
        }

        public void Undo()
        {
            var command = _commands.Pop();
            command.Undo();
        }
    }
}
