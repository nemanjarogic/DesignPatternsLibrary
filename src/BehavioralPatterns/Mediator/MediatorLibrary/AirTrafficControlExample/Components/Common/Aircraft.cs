using System;
using MediatorLibrary.AirTrafficControlExample.Mediators.Common;

namespace MediatorLibrary.AirTrafficControlExample.Components.Common
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _airTraficControl;
        private int _currentAltitude;

        protected Aircraft(string callSign, int currentAltitude, IAirTrafficControl airTraficControl)
        {
            _airTraficControl = airTraficControl;
            _airTraficControl.RegisterAircraftUnderGuidance(this);

            CallSign = callSign;
            Altitude = currentAltitude;
        }

        public abstract int SeatingCapacity { get; }

        public string CallSign { get; private set; }

        public int Altitude
        {
            get
            {
                return _currentAltitude;
            }
            set
            {
                _currentAltitude = value;
                Console.WriteLine($"Aircraft with call sign {CallSign} flies at {_currentAltitude} feet.");

                _airTraficControl.ReceiveAircraftLocation(this);
            }
        }

        public void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return false;
            }

            var incoming = (Aircraft)obj;
            return CallSign.Equals(incoming.CallSign);
        }

        public override int GetHashCode()
        {
            return CallSign.GetHashCode();
        }

        public void WarnOfAirspaceIntrusionBy(Aircraft aircraft)
        {
            // Do something in response to the warning
            Console.WriteLine($"Aircraft {CallSign} has airspace intrusion by {aircraft.CallSign}.");
        }
    }
}
