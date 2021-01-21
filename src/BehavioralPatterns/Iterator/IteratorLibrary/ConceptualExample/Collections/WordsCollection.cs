using System.Collections;
using System.Collections.Generic;
using IteratorLibrary.ConceptualExample.Collections.Common;
using IteratorLibrary.ConceptualExample.Iterators;

namespace IteratorLibrary.ConceptualExample.Collections
{
    public class WordsCollection : IterableCollection
    {
        private readonly List<string> _collection = new List<string>();
        private bool _isDirectionReversed = false;

        public int Count
        {
            get
            {
                return _collection.Count;
            }
        }

        public void Add(string word)
        {
            _collection.Add(word);
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void ReverseDirection()
        {
            _isDirectionReversed = !_isDirectionReversed;
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _isDirectionReversed);
        }
    }
}
