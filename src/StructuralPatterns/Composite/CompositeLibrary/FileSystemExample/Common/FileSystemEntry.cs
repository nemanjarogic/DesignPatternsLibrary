namespace CompositeLibrary.FileSystemExample.Common
{
    public abstract class FileSystemEntry
    {
        public FileSystemEntry(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract double GetSizeInMB();
    }
}
