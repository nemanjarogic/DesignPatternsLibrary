using System.Collections.Generic;
using System.Linq;
using CompositeLibrary.FileSystemExample.Common;

namespace CompositeLibrary.FileSystemExample
{
    public class Folder : FileSystemEntry
    {
        private List<FileSystemEntry> _items;

        public Folder(string name)
            : base(name)
        {
            _items = new List<FileSystemEntry>();
        }

        public void Add(FileSystemEntry entry)
        {
            _items.Add(entry);
        }

        public void Remove(FileSystemEntry entry)
        {
            _items.Remove(entry);
        }

        public override double GetSizeInMB()
        {
            return _items.Sum(item => item.GetSizeInMB());
        }
    }
}
