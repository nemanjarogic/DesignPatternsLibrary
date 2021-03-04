using VisitorLibrary.PersonDynamicProgrammingExample.Elements.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Elements
{
    public class BankAccount : IAsset
    {
        public int Amount { get; set; }

        public double MonthlyInterest { get; set; }
    }
}
