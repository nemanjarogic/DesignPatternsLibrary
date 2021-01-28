using VisitorLibrary.PersonExample.Elements.Common;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Elements
{
    public class Loan : IAsset
    {
        public int Owed { get; set; }

        public int MonthlyPayment { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
