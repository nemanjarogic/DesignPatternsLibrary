using IteratorLibrary.ConceptualExample.Collections;
using IteratorLibrary.ConceptualExample.Iterators.Common;

namespace IteratorLibrary.ConceptualExample.Iterators
{
    /// <summary>
    /// Concrete iterators implement various traversal algorithms.
    /// These classes store the current traversal position at all times.
    /// </summary>
    public class AlphabeticalOrderIterator : Iterator
    {
        /// <summary>
        /// Stores the current traversal position. An iterator may have a lot of
        /// other fields for storing iteration state, especially when it is
        /// supposed to work with a particular kind of collection.
        /// </summary>
        private int _position = -1;

        private readonly WordsCollection _collection;
        private readonly bool _isDirectionReversed = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool isDirectionReversed = false)
        {
            _collection = collection;
            _isDirectionReversed = isDirectionReversed;

            if (isDirectionReversed)
            {
                _position = collection.Count;
            }
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_isDirectionReversed ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _isDirectionReversed ? _collection.Count : -1;
        }
    }
}
