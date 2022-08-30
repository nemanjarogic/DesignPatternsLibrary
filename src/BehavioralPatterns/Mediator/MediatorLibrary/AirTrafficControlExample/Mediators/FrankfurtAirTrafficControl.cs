using MediatorLibrary.AirTrafficControlExample.Components.Common;
using MediatorLibrary.AirTrafficControlExample.Mediators.Common;

namespace MediatorLibrary.AirTrafficControlExample.Mediators;

public class FrankfurtAirTrafficControl : IAirTrafficControl
{
    private readonly Dictionary<string, Aircraft> _aircraftUnderGuidance = new();

    public void ReceiveAircraftLocation(Aircraft reportingAircraft)
    {
        var potentiallyAffectedAircraft = _aircraftUnderGuidance
            .Values
            .Where(a => a.CallSign != reportingAircraft.CallSign);

        foreach (var currentAircraft in potentiallyAffectedAircraft)
        {
            if (Math.Abs(currentAircraft.Altitude - reportingAircraft.Altitude) >= 1000)
            {
                continue;
            }

            Console.WriteLine($"\nAir traffic control will issue a warning to {reportingAircraft.CallSign} aircraft about airspace intrusion.");
            currentAircraft.WarnOfAirspaceIntrusionBy(reportingAircraft);
            reportingAircraft.Climb(1000);
        }
    }

    public void RegisterAircraftUnderGuidance(Aircraft aircraft)
    {
        if (!_aircraftUnderGuidance.ContainsKey(aircraft.CallSign))
        {
            _aircraftUnderGuidance.Add(aircraft.CallSign, aircraft);
        }
    }
}
