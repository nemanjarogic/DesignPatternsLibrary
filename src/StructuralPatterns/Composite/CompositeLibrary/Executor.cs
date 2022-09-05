using BuildingBlocks;
using CompositeLibrary.FileSystemExample;
using CompositeLibrary.GiftExample;
using CompositeLibrary.ShareholdersExample;

namespace CompositeLibrary;

public class Executor : PatternExecutor
{
    public override string Name => "Composite - Structural Pattern";

    public override void Execute()
    {
        FileSystemExecutor.Execute();
        GiftExecutor.Execute();
        ShareholdersExecutor.Execute();
    }
}
