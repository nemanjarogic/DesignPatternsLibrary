using System;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers
{
    public class VicePresident : Approver
    {
        public override void Approve(Purchase purchase)
        {
            if (purchase.Cost < 2000)
            {
                Console.WriteLine($"Vice president approved purchase #{purchase.Number} that cost {purchase.Cost:C}");
                return;
            }

            Next?.Approve(purchase);
        }
    }
}
