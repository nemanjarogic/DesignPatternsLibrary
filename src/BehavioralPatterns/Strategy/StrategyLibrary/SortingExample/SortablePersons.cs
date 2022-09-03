using StrategyLibrary.SortingExample.Strategies.Common;

namespace StrategyLibrary.SortingExample;

public class SortablePersons
{
    private readonly List<Person> _persons;

    public SortablePersons(ISortStrategy sortStrategy)
    {
        SortStrategy = sortStrategy;
        _persons = new List<Person>();
    }

    public ISortStrategy SortStrategy { get; set; }

    public void Add(Person person) => _persons.Add(person);

    public void Clear() => _persons.Clear();

    public IReadOnlyCollection<Person> Sort()
    {
        var sortedPersons = SortStrategy.Sort(_persons);
        return sortedPersons;
    }
}
