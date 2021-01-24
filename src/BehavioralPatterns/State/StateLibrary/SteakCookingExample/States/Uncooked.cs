using StateLibrary.SteakCookingExample.States.Common;

namespace StateLibrary.SteakCookingExample.States
{
    public class Uncooked : Doneness
    {
        public Uncooked(Steak steak, double currentTemperature)
        {
            _steak = steak;
            _currentTemperature = currentTemperature;

            _lowerTemperature = 0;
            _upperTemperature = 49;
            _isSafeToEat = false;
        }

        public Uncooked(Doneness state)
            : this(state.Steak, state.CurrentTemperature)
        {
        }

        public override void CheckDoneness()
        {
            if (_currentTemperature > _upperTemperature)
            {
                _steak.State = new Rare(this);
            }
        }
    }
}
