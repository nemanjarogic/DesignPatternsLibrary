using System;
using BridgeLibrary.DevicesAndRemotesExample.Implementations.Common;

namespace BridgeLibrary.DevicesAndRemotesExample.Implementations
{
    public class Radio : Device
    {
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine("Radio is turned on.");
        }

        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine("Radio is turned off.");
        }
    }
}
