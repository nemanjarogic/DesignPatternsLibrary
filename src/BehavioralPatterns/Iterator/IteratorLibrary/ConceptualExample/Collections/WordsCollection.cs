using System.Collections;
using IteratorLibrary.ConceptualExample.Collections.Common;
using IteratorLibrary.ConceptualExample.Iterators;

namespace IteratorLibrary.ConceptualExample.Collections;

public class WordsCollection : IterableCollection
{
    private readonly List<string> _collection = new();
    private bool _isDirectionReversed;

    public int Count => _collection.Count;

    public void Add(string word) => _collection.Add(word);

    public void ReverseDirection() => _isDirectionReversed = !_isDirectionReversed;

    public override IEnumerator GetEnumerator() => new AlphabeticalOrderIterator(this, _isDirectionReversed);

    public string this[int index] =>
        index >= 0 && index < _collection.Count
            ? _collection[index]
            : throw new ArgumentOutOfRangeException(nameof(index));
}
