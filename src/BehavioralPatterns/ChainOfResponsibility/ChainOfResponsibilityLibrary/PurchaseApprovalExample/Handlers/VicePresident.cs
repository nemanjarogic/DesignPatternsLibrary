using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers;

public class VicePresident : Approver
{
    public override void Approve(Purchase purchase)
    {
        if (purchase.Cost < 2000)
        {
            Console.WriteLine($"The vice-president approved the purchase #{purchase.Number} which cost {purchase.Cost:C}");
            return;
        }

        Next?.Approve(purchase);
    }
}
