using StateLibrary.SteakCookingExample.States.Common;

namespace StateLibrary.SteakCookingExample.States
{
    public class MediumRare : Doneness
    {
        public MediumRare(Doneness state)
            : base(state)
        {
            _lowerTemperature = 55;
            _upperTemperature = 50;
            _isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (_currentTemperature < _lowerTemperature)
            {
                _steak.State = new Rare(this);
            }
            else if (_currentTemperature > _upperTemperature)
            {
                _steak.State = new Medium(this);
            }
        }
    }
}
