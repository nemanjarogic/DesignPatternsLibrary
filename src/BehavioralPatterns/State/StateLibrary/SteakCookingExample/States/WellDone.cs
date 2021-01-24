using StateLibrary.SteakCookingExample.States.Common;

namespace StateLibrary.SteakCookingExample.States
{
    public class WellDone : Doneness
    {
        public WellDone(Doneness state)
            : base(state)
        {
            _lowerTemperature = 65;
            _upperTemperature = 71;
            _isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (_currentTemperature < _lowerTemperature)
            {
                _steak.State = new Medium(this);
            }
            else if (_currentTemperature > _upperTemperature)
            {
                _steak.State = new Overcooked(this);
            }
        }
    }
}
