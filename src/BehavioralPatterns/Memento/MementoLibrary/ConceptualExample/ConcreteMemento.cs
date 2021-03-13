using System;

namespace MementoLibrary.ConceptualExample
{
    /// <summary>
    /// The Concrete Memento contains the infrastructure for storing the Originator's state.
    /// The Memento object acts as a snapshot of the originator’s state.
    /// It’s a common practice to make the memento immutable and
    /// pass it the data only once, via the constructor.
    /// </summary>
    public class ConcreteMemento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _creationDate;

        public ConcreteMemento(string state)
        {
            _state = state;
            _creationDate = DateTime.Now;
        }

        /// <summary>
        /// The Originator uses this method when restoring its state.
        /// </summary>
        /// <returns>State.</returns>
        public string GetState()
        {
            return _state;
        }

        /// <summary>
        /// Used by the Caretaker to display metadata.
        /// </summary>
        /// <returns>Name.</returns>
        public string GetName()
        {
            return $"{_creationDate.ToString("MM/dd/yyyy hh:mm:ss.fff tt")} / ({_state.Substring(0, 9)})...";
        }

        /// <summary>
        /// Used by the Caretaker to display metadata.
        /// </summary>
        /// <returns>Creation date.</returns>
        public DateTime GetCreationDate()
        {
            return _creationDate;
        }
    }
}
