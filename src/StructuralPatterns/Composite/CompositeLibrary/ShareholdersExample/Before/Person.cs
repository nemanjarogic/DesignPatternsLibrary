using System;

namespace CompositeLibrary.ShareholdersExample.Before
{
    public class Person
    {
        public string Name { get; set; }

        public int NumberOfShares { get; set; }

        public void PrintReport()
        {
            Console.WriteLine($"{Name} has {NumberOfShares} shares of the share capital.");
        }
    }
}
