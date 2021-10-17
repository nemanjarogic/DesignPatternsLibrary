namespace LazyLoadLibrary.ValueHolderExample
{
    public class LibraryLoader : IValueLoader<Library>
    {
        public Library Load()
        {
            return new Library();
        }
    }
}
