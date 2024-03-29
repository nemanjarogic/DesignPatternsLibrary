﻿using StrategyLibrary.SortingExample.Strategies.Common;

namespace StrategyLibrary.SortingExample.Strategies;

public class SortByYearOfBirth : ISortStrategy
{
    public IReadOnlyCollection<Person> Sort(IReadOnlyCollection<Person> persons)
    {
        var sortedPersons = new List<Person>(persons);
        sortedPersons.Sort((x, y) => x.YearOfBirth.CompareTo(y.YearOfBirth));

        return sortedPersons;
    }
}
