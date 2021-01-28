using VisitorLibrary.PersonExample.Elements;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Visitors
{
    public class NetWorthVisitor : IVisitor
    {
        public int Total { get; private set; } = 0;

        public void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        public void Visit(Loan loan)
        {
            Total -= loan.Owed;
        }
    }
}
