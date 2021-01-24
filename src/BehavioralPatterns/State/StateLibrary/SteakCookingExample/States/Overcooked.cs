using StateLibrary.SteakCookingExample.States.Common;

namespace StateLibrary.SteakCookingExample.States
{
    public class Overcooked : Doneness
    {
        public Overcooked(Doneness state)
            : base(state)
        {
            _lowerTemperature = 71;
            _upperTemperature = double.MaxValue;
            _isSafeToEat = false;
        }

        public override void CheckDoneness()
        {
            if (_currentTemperature < _lowerTemperature)
            {
                _steak.State = new WellDone(this);
            }
        }
    }
}
