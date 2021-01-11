using System;
using BuildingBlocks;
using MediatorLibrary.AirTrafficControlExample.Components;
using MediatorLibrary.AirTrafficControlExample.Mediators;

namespace MediatorLibrary.AirTrafficControlExample
{
    public static class AirTrafficControlExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Air traffic control example");

            var airTraficControl = new FrankfurtAirTrafficControl();

            // Register flights to air trafic control
            var flight1 = new AirbusA320("ARB320", 28000, airTraficControl);
            var flight2 = new Boeing737("BNG737", 29000, airTraficControl);
            var flight3 = new Boeing777("BNG777", 35000, airTraficControl);

            Console.WriteLine($"\nChanging altitude for {flight1.CallSign}...");
            flight1.Altitude += 1000;
        }
    }
}
