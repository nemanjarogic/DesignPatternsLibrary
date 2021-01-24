using System;
using StateLibrary.PackageExample.States.Common;

namespace StateLibrary.PackageExample.States
{
    public class DeliveredState : PackageState
    {
        public override void Proceed(Package package)
        {
            package.ChangeState(new ReceivedState());
        }

        public override void Revert(Package package)
        {
            package.ChangeState(new OrderedState());
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Package delivered to post office, not received yet.");
        }
    }
}
