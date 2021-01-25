using System.Collections.Generic;

namespace StrategyLibrary.SortingExample.Strategies.Common
{
    public interface ISortStrategy
    {
        List<Person> Sort(List<Person> persons);
    }
}
