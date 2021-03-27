namespace StateLibrary.SteakCookingExample.States.Common
{
    /// <summary>
    /// Doneness is a gauge of how thoroughly cooked a cut of meat is based on
    /// its color, juiciness, and internal temperature when cooked.
    /// In this example we use celsisus degree as a unit of temperature measurment.
    /// </summary>
    public abstract class Doneness
    {
        protected Steak _steak;
        protected double _currentTemperature;
        protected double _lowerTemperature;
        protected double _upperTemperature;
        protected bool _isSafeToEat;
        protected int _temperatureChangeStep;

        protected Doneness(Doneness state)
            : this()
        {
            _steak = state.Steak;
            _currentTemperature = state.CurrentTemperature;
        }

        protected Doneness()
        {
            _temperatureChangeStep = 1;
        }

        public Steak Steak
        {
            get => _steak;
            set => _steak = value;
        }

        public double CurrentTemperature
        {
            get => _currentTemperature;
            set => _currentTemperature = value;
        }

        public virtual void IncreaseTemperature()
        {
            _currentTemperature += _temperatureChangeStep;
            CheckDoneness();
        }

        public virtual void DecreaseTemperature()
        {
            _currentTemperature -= _temperatureChangeStep;
            CheckDoneness();
        }

        public abstract void CheckDoneness();
    }
}
