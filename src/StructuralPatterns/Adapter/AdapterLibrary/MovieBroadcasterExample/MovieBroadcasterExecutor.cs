﻿using BuildingBlocks;

namespace AdapterLibrary.MovieBroadcasterExample;

public static class MovieBroadcasterExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Movie broadcaster example");

        var registry = new MovieRegistry();

        IBroadcaster adapter = new BroadcastAdapter(registry);
        adapter.BroadcastToExternalPartners();
    }
}
