using MediatorLibrary.AirTrafficControlExample.Components.Common;
using MediatorLibrary.AirTrafficControlExample.Mediators.Common;

namespace MediatorLibrary.AirTrafficControlExample.Components
{
    public class Boeing737 : Aircraft
    {
        public Boeing737(string callSign, int currentAltitude, IAirTrafficControl atc)
            : base(callSign, currentAltitude, atc)
        {
        }

        public override int SeatingCapacity
        {
            get
            {
                return 143;
            }
        }
    }
}
