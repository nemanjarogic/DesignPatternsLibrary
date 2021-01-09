using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample.Commands
{
    public class DeleteCommand : ICommand
    {
        private readonly Email _email;

        public DeleteCommand(Email email)
        {
            _email = email;
        }

        public void Execute()
        {
           _email.Delete();
        }
    }
}
