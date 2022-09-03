namespace StrategyLibrary.SortingExample.Strategies.Common;

public interface ISortStrategy
{
    IReadOnlyCollection<Person> Sort(IReadOnlyCollection<Person> persons);
}
