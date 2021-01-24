using StateLibrary.SteakCookingExample.States.Common;

namespace StateLibrary.SteakCookingExample.States
{
    public class Rare : Doneness
    {
        public Rare(Doneness state)
            : base(state)
        {
            _lowerTemperature = 49;
            _upperTemperature = 55;
            _isSafeToEat = true;
        }

        public override void CheckDoneness()
        {
            if (_currentTemperature < _lowerTemperature)
            {
                _steak.State = new Uncooked(this);
            }
            else if (_currentTemperature > _upperTemperature)
            {
                _steak.State = new MediumRare(this);
            }
        }
    }
}
