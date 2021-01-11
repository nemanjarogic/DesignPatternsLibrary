using MediatorLibrary.AirTrafficControlExample.Components.Common;
using MediatorLibrary.AirTrafficControlExample.Mediators.Common;

namespace MediatorLibrary.AirTrafficControlExample.Components
{
    public class Boeing777 : Aircraft
    {
        public Boeing777(string callSign, int currentAltitude, IAirTrafficControl atc)
            : base(callSign, currentAltitude, atc)
        {
        }

        public override int SeatingCapacity
        {
            get
            {
                return 368;
            }
        }
    }
}
