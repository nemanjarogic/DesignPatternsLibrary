using VisitorLibrary.PersonExample.Elements;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Visitors
{
    public class IncomeVisitor : IVisitor
    {
        public double Amount { get; private set; } = 0;

        public void Visit(RealEstate realEstate)
        {
            Amount += realEstate.MonthlyRent;
        }

        public void Visit(BankAccount bankAccount)
        {
            Amount += bankAccount.Amount * bankAccount.MonthlyInterest;
        }

        public void Visit(Loan loan)
        {
            Amount -= loan.MonthlyPayment;
        }
    }
}
