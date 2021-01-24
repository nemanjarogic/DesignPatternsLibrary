using System;
using StateLibrary.PackageExample.States.Common;

namespace StateLibrary.PackageExample.States
{
    public class ReceivedState : PackageState
    {
        public override void Proceed(Package package)
        {
            Console.WriteLine("Package is already received by a client. There is nothing else left to do.");
        }

        public override void Revert(Package package)
        {
            package.ChangeState(new DeliveredState());
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Package received by a client.");
        }
    }
}
