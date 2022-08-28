using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers;

public class Manager : Approver
{
    public override void Approve(Purchase purchase)
    {
        if (purchase.Cost < 500)
        {
            Console.WriteLine($"The manager approved the purchase #{purchase.Number} which cost {purchase.Cost:C}");
            return;
        }

        Next?.Approve(purchase);
    }
}
