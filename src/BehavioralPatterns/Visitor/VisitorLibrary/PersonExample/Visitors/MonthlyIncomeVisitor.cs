using VisitorLibrary.PersonExample.Elements;
using VisitorLibrary.PersonExample.Visitors.Common;

namespace VisitorLibrary.PersonExample.Visitors;

public class MonthlyIncomeVisitor : IVisitor
{
    public double Amount { get; private set; }

    public void Visit(RealEstate realEstate) =>
        Amount += realEstate.MonthlyIncomeFromRenting;

    public void Visit(BankSavingsAccount bankSavingsAccount) =>
        Amount += bankSavingsAccount.Amount * bankSavingsAccount.MonthlyInterest;

    public void Visit(Loan loan) =>
        Amount -= loan.MonthlyPayment;
}
