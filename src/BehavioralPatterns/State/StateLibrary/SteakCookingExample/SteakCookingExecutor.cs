using BuildingBlocks;

namespace StateLibrary.SteakCookingExample
{
    public static class SteakCookingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Steak cooking example");

            Steak steak = new Steak("T-Bone", 48);

            steak.IncreaseTemperature();
            steak.IncreaseTemperature();
        }
    }
}
