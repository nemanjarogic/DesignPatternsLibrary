using BridgeLibrary.DevicesAndRemotesExample.Abstractions;
using BridgeLibrary.DevicesAndRemotesExample.Implementations;
using System;

namespace BridgeLibrary.DevicesAndRemotesExample
{
    public static class DevicesAndRemotesExecutor
    {
        public static void Execute()
        {
            var radioRemote = new UniversalRemoteControl(new SmartTV());
            radioRemote.TogglePower();
            radioRemote.TogglePower();

            Console.WriteLine();

            var advancedRemote = new AdvancedRemoteControl(new SmartTV());
            advancedRemote.TogglePower();
            advancedRemote.Mute();
            advancedRemote.TogglePower();
        }
    }
}
