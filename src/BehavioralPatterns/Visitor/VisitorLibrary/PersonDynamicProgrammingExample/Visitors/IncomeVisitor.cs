using VisitorLibrary.PersonDynamicProgrammingExample.Elements;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Visitors
{
    public class IncomeVisitor : AssetVisitor
    {
        public double Amount { get; private set; } = 0;

        protected override void Visit(RealEstate realEstate)
        {
            Amount += realEstate.MonthlyRent;
        }

        protected override void Visit(BankAccount bankAccount)
        {
            Amount += bankAccount.Amount * bankAccount.MonthlyInterest;
        }

        protected override void Visit(Loan loan)
        {
            Amount -= loan.MonthlyPayment;
        }
    }
}
