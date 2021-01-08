namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common
{
    public abstract class Approver
    {
        protected Approver Next { get; private set; }

        public Approver RegisterNext(Approver next)
        {
            Next = next;
            return Next;
        }

        public abstract void Approve(Purchase purchase);
    }
}
