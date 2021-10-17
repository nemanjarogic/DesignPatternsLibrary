using System;

namespace LazyLoadLibrary.ValueHolderExample
{
    /// <summary>
    /// Value holder pattern is pretty much similar to <see cref="Lazy{T}"/>.
    /// </summary>
    public class ValueHolderCollege
    {
        private readonly ValueHolder<Library> _library;

        public ValueHolderCollege(int id)
        {
            Id = id;

            // Value holder is usually injected through the constructor.
            _library = new ValueHolder<Library>(new LibraryLoader());

            Console.WriteLine("College initialization completed.");
        }

        public int Id { get; set; }

        public Library Library
        {
            get
            {
                return _library.Value;
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine(
                $"College library with {Library.NumberOfBooks} books " +
                $"was established on {Library.EstablishmentDate.ToShortDateString()}.");
        }
    }
}
