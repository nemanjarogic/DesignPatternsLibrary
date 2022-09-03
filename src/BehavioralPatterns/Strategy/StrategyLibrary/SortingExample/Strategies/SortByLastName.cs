using StrategyLibrary.SortingExample.Strategies.Common;

namespace StrategyLibrary.SortingExample.Strategies;

public class SortByLastName : ISortStrategy
{
    public IReadOnlyCollection<Person> Sort(IReadOnlyCollection<Person> persons)
    {
        var sortedPersons = new List<Person>(persons);
        sortedPersons.Sort((x, y) => x.LastName.CompareTo(y.LastName));

        return sortedPersons;
    }
}
