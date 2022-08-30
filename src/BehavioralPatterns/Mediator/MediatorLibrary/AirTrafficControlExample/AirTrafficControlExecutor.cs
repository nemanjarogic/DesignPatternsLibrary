using BuildingBlocks;
using MediatorLibrary.AirTrafficControlExample.Components;
using MediatorLibrary.AirTrafficControlExample.Mediators;

namespace MediatorLibrary.AirTrafficControlExample;

public static class AirTrafficControlExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Air traffic control example");

        var airTrafficControl = new FrankfurtAirTrafficControl();

        var flight1 = new AirbusA320("ARB320", 28000, airTrafficControl);
        var flight2 = new Boeing737("BNG737", 29000, airTrafficControl);
        var flight3 = new Boeing777("BNG777", 35000, airTrafficControl);
        Console.WriteLine($"\nAir traffic control has registered aircraft with the call signs {flight1.CallSign}, {flight2.CallSign} and {flight3.CallSign}.");

        Console.WriteLine($"\nChanging altitude for {flight1.CallSign}...");
        flight1.Altitude += 1000;
    }
}
