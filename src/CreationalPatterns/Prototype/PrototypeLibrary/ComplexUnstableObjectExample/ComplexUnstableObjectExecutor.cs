using BuildingBlocks;

namespace PrototypeLibrary.ComplexUnstableObjectExample
{
    public static class ComplexUnstableObjectExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Complex unstable object example");

            var complicatedObject = new ComplexUnstableObject("a", 'c', "e");

            // Clients from different assembly can't call constructor
            // because it's internal,but they can call Clone.
            var complicatedObject2 = complicatedObject.Clone();
        }
    }
}
