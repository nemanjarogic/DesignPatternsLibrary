using VisitorLibrary.PersonDynamicProgrammingExample.Elements;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Visitors
{
    public class NetWorthVisitor : AssetVisitor
    {
        public int Total { get; private set; } = 0;

        protected override void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        protected override void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        protected override void Visit(Loan loan)
        {
            Total -= loan.Owed;
        }
    }
}
