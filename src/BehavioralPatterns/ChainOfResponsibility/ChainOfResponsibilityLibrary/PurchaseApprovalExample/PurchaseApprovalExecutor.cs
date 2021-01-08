using BuildingBlocks;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers;

namespace ChainOfResponsibilityLibrary.ApprovalExample
{
    public static class PurchaseApprovalExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Purchase approval example");

            Approver manager = new Manager();
            Approver director = new Director();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            manager
                .RegisterNext(director)
                .RegisterNext(vicePresident)
                .RegisterNext(president)
                .RegisterNext(ExecutiveMeeting.Instance);

            var lowCostPurchase = new Purchase { Number = 1, Cost = 400, Purpose = "Whiteboard purchase." };
            var mediumCostPurchase = new Purchase { Number = 2, Cost = 3000, Purpose = "Laptops purchase." };
            var highCostPurchase = new Purchase { Number = 3, Cost = 11500, Purpose = "Car purchase." };

            manager.Approve(lowCostPurchase);
            manager.Approve(mediumCostPurchase);
            manager.Approve(highCostPurchase);
        }
    }
}
