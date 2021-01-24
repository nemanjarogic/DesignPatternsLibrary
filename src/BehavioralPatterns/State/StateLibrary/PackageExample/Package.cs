using StateLibrary.PackageExample.States;
using StateLibrary.PackageExample.States.Common;

namespace StateLibrary.PackageExample
{
    public class Package
    {
        private PackageState _state = new OrderedState();

        public void Proceed()
        {
            _state.Proceed(this);
        }

        public void Revert()
        {
            _state.Revert(this);
        }

        public void PrintStatus()
        {
            _state.PrintStatus();
        }

        public void ChangeState(PackageState state)
        {
            _state = state;
        }
    }
}
