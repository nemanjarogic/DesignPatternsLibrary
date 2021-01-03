using System;

namespace BridgeLibrary.DevicesAndRemotesExample.Implementations.Common
{
    /// <summary>
    /// The "implementation" contract declares methods common to all concrete implementation classes.
    /// It doesn't have to match the abstraction's interface.
    /// In fact, the two interfaces can be entirely different.
    /// Typically the implementation interface provides only primitive operations,
    /// while the abstraction defines higher-level operations based on those primitives.
    /// </summary>
    public abstract class Device
    {
        private int _volume;
        private int _channel;

        public Device()
        {
            Console.WriteLine("Device turning on process started...");

            Volume = 20;
            Channel = 1;
            NumberOfChannels = 100;
            IsTurnedOn = false;
        }

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
                Console.WriteLine($"Device volume is set to: {_volume}");
            }
        }

        public int Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                _channel = value;
                Console.WriteLine($"Device channel is set to: {_channel}");
            }
        }

        public int NumberOfChannels { get; init; }

        public bool IsTurnedOn { get; private set; }

        public virtual void TurnOn()
        {
            IsTurnedOn = true;
        }

        public virtual void TurnOff()
        {
            IsTurnedOn = false;
        }
    }
}
