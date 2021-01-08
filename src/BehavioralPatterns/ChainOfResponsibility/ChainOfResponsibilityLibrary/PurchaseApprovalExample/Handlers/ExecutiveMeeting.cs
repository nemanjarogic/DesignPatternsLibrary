using System;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers
{
    /// <summary>
    /// Executive meeting represents end of chain handler.
    /// </summary>
    public class ExecutiveMeeting : Approver
    {
        private static readonly ExecutiveMeeting _instance = new ExecutiveMeeting();

        private ExecutiveMeeting()
        {
        }

        public static ExecutiveMeeting Instance
        {
            get
            {
                return _instance;
            }
        }

        public override void Approve(Purchase purchase)
        {
            Console.WriteLine(
                $"Purchase #{purchase.Number} that cost {purchase.Cost:C} requires " +
                $"an executive meeting in order to be approved.");
        }
    }
}
