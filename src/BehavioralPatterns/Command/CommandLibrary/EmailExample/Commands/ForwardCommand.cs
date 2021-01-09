using CommandLibrary.EmailExample.Commands.Common;

namespace CommandLibrary.EmailExample.Commands
{
    public class ForwardCommand : ICommand
    {
        private readonly Email _email;

        public ForwardCommand(Email email)
        {
            _email = email;
        }

        public void Execute()
        {
            _email.Forward();
        }
    }
}
