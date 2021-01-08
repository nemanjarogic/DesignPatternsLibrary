using System;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers
{
    public class President : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 5000)
            {
                Console.WriteLine($"President approved purchase #{purchase.Number} that cost {purchase.Cost:C}");
                return;
            }

            Next?.Approve(purchase);
        }
    }
}
