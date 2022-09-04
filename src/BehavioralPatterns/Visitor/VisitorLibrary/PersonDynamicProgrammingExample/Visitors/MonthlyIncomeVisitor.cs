using VisitorLibrary.PersonDynamicProgrammingExample.Elements;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors.Common;

namespace VisitorLibrary.PersonDynamicProgrammingExample.Visitors;

public class MonthlyIncomeVisitor : AssetVisitor
{
    public double Amount { get; private set; }

    protected override void Visit(RealEstate realEstate) =>
        Amount += realEstate.MonthlyIncomeFromRenting;

    protected override void Visit(BankSavingsAccount bankSavingsAccount) =>
        Amount += bankSavingsAccount.Amount * bankSavingsAccount.MonthlyInterest;

    protected override void Visit(Loan loan) =>
        Amount -= loan.MonthlyPayment;
}
