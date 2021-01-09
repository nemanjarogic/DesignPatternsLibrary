using BuildingBlocks;
using CommandLibrary.EmailExample.Commands;

namespace CommandLibrary.EmailExample
{
    public static class EmailExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Email example");

            var email = new Email();

            var readCommand = new ReadCommand(email);
            var forwardCommand = new ForwardCommand(email);
            var deleteCommand = new DeleteCommand(email);

            var toolbar = new Toolbar(readCommand, forwardCommand, deleteCommand);

            toolbar.ReadEmail();
            toolbar.ForwardEmail();
            toolbar.DeleteEmail();
        }
    }
}
