using IteratorLibrary.MusicFestivalsExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalsExample.Collections.Common
{
    public interface IIterableCollection
    {
        IIterator CreateIterator();
    }
}
