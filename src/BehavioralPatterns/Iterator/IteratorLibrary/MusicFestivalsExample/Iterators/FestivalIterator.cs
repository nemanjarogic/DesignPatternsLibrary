using IteratorLibrary.MusicFestivalsExample.Collections;
using IteratorLibrary.MusicFestivalsExample.Iterators.Common;

namespace IteratorLibrary.MusicFestivalsExample.Iterators;

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

    // It's probably more logical to have a method for changing the step.
    // However, for demo purposes the idea was to show that iterator interface can contain properties too.
    public int Step
    {
        get => _step;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "The step can be only positive value. The current iterator doesn't support going backward.");
            }

            _step = value;
        }
    }

    public MusicFestival First()
    {
        _position = 0;
        return Current();
    }

    public MusicFestival Current() => _collection.Get(_position);

    public bool MoveNext()
    {
        var updatedPosition = _position + _step;

        if (updatedPosition < _collection.Count)
        {
            _position = updatedPosition;
            return true;
        }

        return false;
    }

    public void Reset() => _position = -1;
}
