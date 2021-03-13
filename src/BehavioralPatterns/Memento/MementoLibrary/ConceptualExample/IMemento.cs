using System;

namespace MementoLibrary.ConceptualExample
{
    /// <summary>
    /// The Memento interface provides a way to retrieve the
    /// memento's metadata, such as creation date or name.
    /// However, it doesn't expose the Originator's state.
    /// </summary>
    public interface IMemento
    {
        DateTime GetCreationDate();

        string GetName();
    }
}
