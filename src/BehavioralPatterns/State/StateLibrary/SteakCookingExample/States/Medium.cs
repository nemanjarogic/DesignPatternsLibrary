using StateLibrary.SteakCookingExample.States.Common;

namespace StateLibrary.SteakCookingExample.States
{
    public class Medium : Doneness
    {
        public Medium(Doneness state)
            : base(state)
        {
            _lowerTemperature = 60;
            _upperTemperature = 65;
            _isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (_currentTemperature < _lowerTemperature)
            {
                _steak.State = new MediumRare(this);
            }
            else if (_currentTemperature > _upperTemperature)
            {
                _steak.State = new WellDone(this);
            }
        }
    }
}
