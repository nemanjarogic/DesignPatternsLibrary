using IteratorLibrary.MusicFestivalsExample.Collections.Common;
using IteratorLibrary.MusicFestivalsExample.Iterators;
using IteratorLibrary.MusicFestivalsExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalsExample.Collections;

public class FestivalCollection : IIterableCollection
{
    private readonly List<MusicFestival> _festivals = new();

    public int Count => _festivals.Count;

    public void Add(MusicFestival festival) => _festivals.Add(festival);

    public MusicFestival Get(int index) => _festivals[index];

    public IIterator CreateIterator() => new FestivalIterator(this);
}
