using System;

namespace LazyLoadLibrary.LazyInitializationExample
{
    public class DotNetLazyCollege
    {
        private readonly Lazy<Library> _library;

        public DotNetLazyCollege()
        {
            // Lazy<T> by default makes instance usable concurrently by multiple threads.
            // We can set isThreadSafe flag explicitly to false if that is not needed.
            _library = new Lazy<Library>(() => new Library());
        }

        public Library Library
        {
            get
            {
                return _library.Value;
            }
        }

        public void ShowDetails()
        {
            // We can access to data through property or via field.Value
            Console.WriteLine(
                $"College library with {Library.NumberOfBooks} books " +
                $"was established on {_library.Value.EstablishmentDate.ToShortDateString()}.");
        }
    }
}
