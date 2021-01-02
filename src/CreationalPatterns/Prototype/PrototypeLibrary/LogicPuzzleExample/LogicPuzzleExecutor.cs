using System;
using BuildingBlocks;

namespace PrototypeLibrary.LogicPuzzleExample
{
    public static class LogicPuzzleExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Logic puzzle example");

            var puzzle = new LogicPuzzle();

            puzzle.SwitchBlueSwitch();
            puzzle.ToggleBigToggle();
            puzzle.SwitchBlueSwitch();
            puzzle.ToggleSmallToggle();
            puzzle.SwitchRedSwitch();

            puzzle.PrintState();

            // What if we need copy of the object now? We don't want to call all methods again.
            // Object had complex state, and prototype pattern can be really useful.
            var puzzle2 = puzzle.Clone() as LogicPuzzle;

            Console.WriteLine("\nCopy puzzle");
            puzzle2.PrintState();
        }
    }
}
