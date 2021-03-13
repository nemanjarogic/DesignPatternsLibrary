using System;
using System.Collections.Generic;

namespace MementoLibrary.ConceptualExample
{
    /// <summary>
    /// The Caretaker doesn't depend on the Concrete Memento class.
    /// Therefore, it doesn't have access to the originator's state, stored inside the memento.
    /// It works with all mementos via the base Memento interface.
    /// </summary>
    public class Caretaker
    {
        private readonly Stack<IMemento> _mementos;
        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
            _mementos = new Stack<IMemento>();
        }

        public void Backup()
        {
            Console.WriteLine("Caretaker: Saving Originator's state...");

            _mementos.Push(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Pop();
            Console.WriteLine($"Caretaker: Restoring state to: {memento.GetName()}");

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("\nCaretaker: Here's the list of mementos:");

            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
