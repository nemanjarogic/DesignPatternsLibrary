namespace CommandLibrary.ShoppingCartExample.Commands.Common
{
    public interface ICommand
    {
        bool CanExecute();

        void Execute();

        void Undo();
    }
}
