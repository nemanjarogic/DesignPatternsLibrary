using VisitorLibrary.PersonExample.Elements;

namespace VisitorLibrary.PersonExample.Visitors.Common
{
    /// <summary>
    /// The visitor interface declares a set of visiting methods that correspond
    /// to element classes. The signature of a visiting method allows the visitor
    /// to identify the exact class of the component that it's dealing with.
    /// </summary>
    public interface IVisitor
    {
        void Visit(RealEstate realEstate);

        void Visit(BankAccount bankAccount);

        void Visit(Loan loan);
    }
}
