using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers;

public class Director : Approver
{
    public override void Approve(Purchase purchase)
    {
        if (purchase.Cost < 1000)
        {
            Console.WriteLine($"The director approved the purchase #{purchase.Number} which cost {purchase.Cost:C}");
            return;
        }

        Next?.Approve(purchase);
    }
}
