using System;
using StateLibrary.PackageExample.States.Common;

namespace StateLibrary.PackageExample.States
{
    public class OrderedState : PackageState
    {
        public override void Proceed(Package package)
        {
            package.ChangeState(new DeliveredState());
        }

        public override void Revert(Package package)
        {
            Console.WriteLine("State can't be reverted. Package is in ordered state, which is its initial state.");
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Package ordered, not delivered to the office yet.");
        }
    }
}
