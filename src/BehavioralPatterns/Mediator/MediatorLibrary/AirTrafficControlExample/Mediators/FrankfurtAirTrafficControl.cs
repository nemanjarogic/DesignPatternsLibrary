using System;
using System.Collections.Generic;
using System.Linq;
using MediatorLibrary.AirTrafficControlExample.Components.Common;
using MediatorLibrary.AirTrafficControlExample.Mediators.Common;

namespace MediatorLibrary.AirTrafficControlExample.Mediators
{
    public class FrankfurtAirTrafficControl : IAirTrafficControl
    {
        private readonly IList<Aircraft> _aircraftsUnderGuidance = new List<Aircraft>();

        public void ReceiveAircraftLocation(Aircraft reportingAircraft)
        {
            foreach (var currentAircraft in _aircraftsUnderGuidance.Where(x => x != reportingAircraft))
            {
                if (Math.Abs(currentAircraft.Altitude - reportingAircraft.Altitude) < 1000)
                {
                    Console.WriteLine($"\nAir traffic control will issue request to {reportingAircraft.CallSign} to change altitude.");

                    currentAircraft.WarnOfAirspaceIntrusionBy(reportingAircraft);
                    reportingAircraft.Climb(1000);
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!_aircraftsUnderGuidance.Contains(aircraft))
            {
                _aircraftsUnderGuidance.Add(aircraft);
            }
        }
    }
}
