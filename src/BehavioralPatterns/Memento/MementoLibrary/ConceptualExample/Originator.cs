using System;
using System.Linq;

namespace MementoLibrary.ConceptualExample
{
    /// <summary>
    /// The Originator holds some important state that may change over time.
    /// It also defines a method for saving the state inside a memento and another
    /// method for restoring the state from it.
    /// </summary>
    public class Originator
    {
        /// <summary>
        /// For the sake of simplicity, the originator's state is stored inside a single variable.
        /// </summary>
        private string _state;

        private static readonly Random random = new Random();

        public Originator(string state)
        {
            _state = state;
            Console.WriteLine($"Originator: My initial state is: {state}");
        }

        /// <summary>
        /// The Originator's business logic may affect its internal state.
        /// Therefore, the client should backup the state before launching
        /// methods of the business logic via the Save() method.
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine("\nOriginator: I'm doing something important.");

            _state = GenerateRandomString(30);

            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        /// <summary>
        /// Saves the current state inside a memento.
        /// </summary>
        /// <returns>Memento.</returns>
        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }

        /// <summary>
        /// Restores the Originator's state from a memento object.
        /// </summary>
        /// <param name="memento">Memento.</param>
        public void Restore(IMemento memento)
        {
            if (memento is not ConcreteMemento concreteMemento)
            {
                throw new Exception($"Unknown memento: {memento}");
            }

            _state = concreteMemento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var randomCharacters = Enumerable.Repeat(characters, length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray();

            return new string(randomCharacters);
        }
    }
}
