using System.Collections.Generic;
using IteratorLibrary.MusicFestivalsExample.Collections.Common;
using IteratorLibrary.MusicFestivalsExample.Iterators;
using IteratorLibrary.MusicFestivalsExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalsExample.Collections
{
    public class FestivalCollection : IIterableCollection
    {
        private readonly List<MusicFestival> _festivals = new List<MusicFestival>();

        public int Count
        {
            get { return _festivals.Count; }
        }

        public void Add(MusicFestival festival)
        {
            _festivals.Add(festival);
        }

        public MusicFestival Get(int index)
        {
            return _festivals[index];
        }

        public IIterator CreateIterator()
        {
            return new FestivalIterator(this);
        }
    }
}
