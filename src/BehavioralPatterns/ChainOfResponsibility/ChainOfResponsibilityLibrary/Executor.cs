using BuildingBlocks;
using ChainOfResponsibilityLibrary.LoggingExample;
using ChainOfResponsibilityLibrary.PokerExample;
using ChainOfResponsibilityLibrary.PurchaseApprovalExample;

namespace ChainOfResponsibilityLibrary;

public class Executor : PatternExecutor
{
    public override string Name => "Chain Of Responsibility - Behavioral Pattern";

    public override void Execute()
    {
        LoggingExecutor.Execute();
        PokerExecutor.Execute();
        PurchaseApprovalExecutor.Execute();
    }
}
