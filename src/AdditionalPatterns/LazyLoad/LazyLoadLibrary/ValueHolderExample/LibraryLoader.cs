using System;

namespace LazyLoadLibrary.ValueHolderExample
{
    public class LibraryLoader : IValueLoader<Library>
    {
        public Library Load()
        {
            Console.WriteLine("Loading library...");
            return new Library();
        }
    }
}
