using IteratorLibrary.MusicFestivalsExample.Collections;
using IteratorLibrary.MusicFestivalsExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalsExample.Iterators
{
    public class FestivalIterator : IIterator
    {
        private readonly FestivalCollection _collection;
        private int _position;
        private int _step;

        public FestivalIterator(FestivalCollection collection)
        {
            _collection = collection;
            _position = -1;
            _step = 1;
        }

        public int Step
        {
            get
            {
                return _step;
            }
            set
            {
                _step = value;
            }
        }

        public MusicFestival First()
        {
            _position = 0;
            return Current();
        }

        public MusicFestival Current()
        {
            return _collection.Get(_position);
        }

        public bool MoveNext()
        {
            int updatedPosition = _position + _step;

            if (updatedPosition < _collection.Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
