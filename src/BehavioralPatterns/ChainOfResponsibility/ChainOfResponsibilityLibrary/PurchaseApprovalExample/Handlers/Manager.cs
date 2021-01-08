using System;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers
{
    public class Manager : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 500)
            {
                Console.WriteLine($"Manager approved purchase #{purchase.Number} that cost {purchase.Cost:C}");
                return;
            }

            Next?.Approve(purchase);
        }
    }
}
