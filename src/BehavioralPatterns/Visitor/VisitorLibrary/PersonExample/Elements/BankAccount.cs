using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Elements
{
    public class BankAccount : IAsset
    {
        public int Amount { get; set; }

        public double MonthlyInterest { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
