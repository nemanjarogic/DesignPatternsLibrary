using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample.Commands
{
    public class ReadCommand : ICommand
    {
        private readonly Email _email;

        public ReadCommand(Email email)
        {
            _email = email;
        }

        public void Execute()
        {
            _email.Read();
        }
    }
}
