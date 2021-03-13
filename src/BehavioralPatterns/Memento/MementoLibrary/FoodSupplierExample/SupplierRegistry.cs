using System;
using System.Collections.Generic;

namespace MementoLibrary.FoodSupplierExample
{
    /// <summary>
    /// A caretaker can keep track of the originator’s history by storing a stack of mementos.
    /// </summary>
    public class SupplierRegistry
    {
        private readonly FoodSupplier _supplier;
        private readonly Stack<IMemento> _undoStack;
        private readonly Stack<IMemento> _redoStack;

        public SupplierRegistry(FoodSupplier supplier)
        {
            _supplier = supplier;
            _undoStack = new Stack<IMemento>();
            _redoStack = new Stack<IMemento>();
        }

        public void Backup()
        {
            Console.WriteLine("\nSupplier registry: Performing backup operation...");

            _redoStack.Clear();
            _undoStack.Push(_supplier.Save());
        }

        public void Undo()
        {
            Console.WriteLine("\nSupplier registry: Performing undo operation...");

            var top = _undoStack.Pop();
            _redoStack.Push(_supplier.Restore(top));
        }

        public void Redo()
        {
            Console.WriteLine("\nSupplier registry: Performing redo operation...");

            var top = _redoStack.Pop();
            _undoStack.Push(_supplier.Restore(top));
        }
    }
}
