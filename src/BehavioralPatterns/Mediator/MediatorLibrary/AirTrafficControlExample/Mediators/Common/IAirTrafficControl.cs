using MediatorLibrary.AirTrafficControlExample.Components.Common;

namespace MediatorLibrary.AirTrafficControlExample.Mediators.Common
{
    public interface IAirTrafficControl
    {
        void ReceiveAircraftLocation(Aircraft reportingAircraft);

        void RegisterAircraftUnderGuidance(Aircraft aircraft);
    }
}
