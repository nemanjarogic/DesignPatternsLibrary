using System;
using BridgeLibrary.DevicesAndRemotesExample.Abstractions;
using BridgeLibrary.DevicesAndRemotesExample.Implementations;
using BuildingBlocks;

namespace BridgeLibrary.DevicesAndRemotesExample
{
    public static class DevicesAndRemotesExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Devices and remotes example");

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
