using BuildingBlocks;
using FluentInterfaceLibrary.BlobStorageExample;
using FluentInterfaceLibrary.LinqExample;

namespace FluentInterfaceLibrary;

public class Executor : PatternExecutor
{
    public override string Name => "Fluent Interface - Creational Pattern";

    public override void Execute()
    {
        BlobStorageExecutor.Execute();
        LinqExecutor.Execute();
    }
}