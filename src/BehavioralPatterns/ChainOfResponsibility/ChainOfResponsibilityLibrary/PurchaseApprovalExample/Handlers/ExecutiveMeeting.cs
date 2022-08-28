using ChainOfResponsibilityLibrary.PurchaseApprovalExample.Common;

namespace ChainOfResponsibilityLibrary.PurchaseApprovalExample.Handlers;

/// <summary>
/// Executive meeting represents end of chain handler.
/// </summary>
public class ExecutiveMeeting : Approver
{
    public static readonly ExecutiveMeeting Instance = new();

    private ExecutiveMeeting()
    {
    }

    public override void Approve(Purchase purchase) =>
        Console.WriteLine(
            $"The purchase #{purchase.Number} which cost {purchase.Cost:C} requires " +
            "an executive meeting in order to be approved.");
}
