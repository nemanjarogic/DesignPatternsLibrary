using System;
using CompositeLibrary.ShareholdersExample.After.Common;

namespace CompositeLibrary.ShareholdersExample.After
{
    public class Person : Shareholder
    {
        public override void PrintReport()
        {
            Console.WriteLine($"{Name} has {NumberOfShares} shares of the share capital.");
        }
    }
}
