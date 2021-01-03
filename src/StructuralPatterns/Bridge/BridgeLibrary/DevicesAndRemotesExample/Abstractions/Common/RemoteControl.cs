using BridgeLibrary.DevicesAndRemotesExample.Implementations.Common;

namespace BridgeLibrary.DevicesAndRemotesExample.Abstractions.Common
{
    /// <summary>
    /// The "abstraction" defines the contract for the "control" part of the two class hierarchies.
    /// It maintains a reference to an object of the "implementation" hierarchy and delegates
    /// all of the real work to this object.
    /// </summary>
    public abstract class RemoteControl
    {
        protected readonly Device _device;
        protected readonly int _volumeChangeStep;

        public RemoteControl(Device device)
        {
            _device = device;
            _volumeChangeStep = 5;
        }

        public void TogglePower()
        {
            if (_device.IsTurnedOn)
            {
                _device.TurnOff();
                return;
            }

            _device.TurnOn();
        }

        public void VolumeUp()
        {
            var newVolume = _device.Volume + _volumeChangeStep;
            if (newVolume > 100)
            {
                newVolume = 100;
            }

            _device.Volume = newVolume;
        }

        public void VolumeDown()
        {
            var newVolume = _device.Volume + _volumeChangeStep;
            if (newVolume < 0)
            {
                newVolume = 0;
            }

            _device.Volume = newVolume;
        }

        public void ChannelUp()
        {
            var newChannel = _device.Channel + 1;
            if (newChannel > _device.NumberOfChannels)
            {
                newChannel = 1;
            }

            _device.Channel = newChannel;
        }

        public void ChannelDown()
        {
            var newChannel = _device.Channel - 1;
            if (newChannel < 0)
            {
                newChannel = _device.NumberOfChannels;
            }

            _device.Channel = newChannel;
        }
    }
}
