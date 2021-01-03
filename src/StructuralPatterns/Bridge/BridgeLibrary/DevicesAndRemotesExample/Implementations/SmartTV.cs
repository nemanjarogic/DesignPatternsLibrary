using System;
using BridgeLibrary.DevicesAndRemotesExample.Implementations.Common;

namespace BridgeLibrary.DevicesAndRemotesExample.Implementations
{
    public class SmartTV : Device
    {
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine("Smart TV is turned on.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine("Smart TV is turned off.");
        }
    }
}
