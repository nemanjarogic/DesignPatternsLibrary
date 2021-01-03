using System;
using BridgeLibrary.DevicesAndRemotesExample.Abstractions.Common;
using BridgeLibrary.DevicesAndRemotesExample.Implementations.Common;

namespace BridgeLibrary.DevicesAndRemotesExample.Abstractions
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device)
            : base(device)
        {
        }

        public virtual void Mute()
        {
            Console.WriteLine("Mute smart TV Command is issued through advanced remote.");
            _device.Volume = 0;
        }
    }
}
