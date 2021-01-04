using CompositeLibrary.FileSystemExample.Common;

namespace CompositeLibrary.FileSystemExample
{
    public class File : FileSystemEntry
    {
        public File(string name, double size)
            : base(name)
        {
            Size = size;
        }

        public double Size { get; }

        public override double GetSizeInMB()
        {
            return Size;
        }
    }
}
