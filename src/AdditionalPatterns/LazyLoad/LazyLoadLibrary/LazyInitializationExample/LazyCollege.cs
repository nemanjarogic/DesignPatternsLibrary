using System;

namespace LazyLoadLibrary.LazyInitializationExample
{
    public class LazyCollege
    {
        private Library _library;

        public Library Library
        {
            get
            {
                if (_library == null)
                {
                    // This works, but it's not thread-safe.
                    _library = new Library();
                }

                return _library;
            }
        }

        public void ShowDetails()
        {
            // We must access library via property.
            Console.WriteLine(
                $"College library with {Library.NumberOfBooks} books " +
                $"was established on {Library.EstablishmentDate.ToShortDateString()}.");
        }
    }
}
