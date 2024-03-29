﻿using BridgeLibrary.DevicesAndRemotesExample;
using BridgeLibrary.DocumentsAndFormattersExample;
using BridgeLibrary.MovieLicenseExample;
using BuildingBlocks;

namespace BridgeLibrary;

public class Executor : PatternExecutor
{
    public override string Name => "Bridge - Structural Pattern";

    public override void Execute()
    {
        DevicesAndRemotesExecutor.Execute();
        DocumentsAndFormattersExecutor.Execute();
        MovieLicenseExecutor.Execute();
    }
}
