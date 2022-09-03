using StrategyLibrary.SortingExample.Strategies.Common;

namespace StrategyLibrary.SortingExample.Strategies;

public class SortByFirstName : ISortStrategy
{
    public IReadOnlyCollection<Person> Sort(IReadOnlyCollection<Person> persons)
    {
        var sortedPersons = new List<Person>(persons);
        sortedPersons.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));

        return sortedPersons;
    }
}
