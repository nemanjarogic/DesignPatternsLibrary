using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample
{
    public class Toolbar
    {
        private readonly ICommand _readCommand;
        private readonly ICommand _forwardCommand;
        private readonly ICommand _deleteCommand;

        public Toolbar(ICommand readCommand, ICommand forwardCommand, ICommand deleteCommand)
        {
            _readCommand = readCommand;
            _forwardCommand = forwardCommand;
            _deleteCommand = deleteCommand;
        }

        public void ReadEmail()
        {
            _readCommand.Execute();
        }

        public void ForwardEmail()
        {
            _forwardCommand.Execute();
        }

        public void DeleteEmail()
        {
            _deleteCommand.Execute();
        }
    }
}
