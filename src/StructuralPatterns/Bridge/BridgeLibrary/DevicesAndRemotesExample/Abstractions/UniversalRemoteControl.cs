using BridgeLibrary.DevicesAndRemotesExample.Abstractions.Common;
using BridgeLibrary.DevicesAndRemotesExample.Implementations.Common;

namespace BridgeLibrary.DevicesAndRemotesExample.Abstractions
{
    public class UniversalRemoteControl : RemoteControl
    {
        public UniversalRemoteControl(Device device)
            : base(device)
        {
        }
    }
}
