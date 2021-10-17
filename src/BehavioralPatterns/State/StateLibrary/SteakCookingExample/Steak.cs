using System;
using StateLibrary.SteakCookingExample.States;
using StateLibrary.SteakCookingExample.States.Common;

namespace StateLibrary.SteakCookingExample
{
    public class Steak
    {
        private readonly string _name;
        private Doneness _state;

        public Steak(string name, double startingTemperature)
        {
            _name = name;
            _state = new Uncooked(this, startingTemperature);
        }

        public double CurrentTemperature => _state.CurrentTemperature;

        public Doneness State
        {
            get => _state;
            set => _state = value;
        }

        public void IncreaseTemperature()
        {
            _state.IncreaseTemperature();

            Console.WriteLine($"Temperature is increased.");
            Console.WriteLine($"Current temperature is {_state.CurrentTemperature}°C");
            Console.WriteLine($"Cooking at this temperature will make the steak: {_state.GetType().Name}");
            Console.WriteLine();
        }

        public void DecreaseTemperature()
        {
            _state.DecreaseTemperature();

            Console.WriteLine($"Temperature is decreased.");
            Console.WriteLine($"Current temperature is {_state.CurrentTemperature}°C");
            Console.WriteLine($"Cooking at this temperature will make the steak: {_state.GetType().Name}");
            Console.WriteLine();
        }
    }
}
