using BuildingBlocks;

namespace PrototypeLibrary.LogicPuzzleExample;

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

        Console.WriteLine("\nState of the original puzzle...");
        puzzle.PrintState();

        // What if we need copy of the object now?
        // We don't want to call all methods that are executed until this point again.
        // The object has a complex state and prototype pattern can be really useful.
        var puzzle2 = (puzzle.Clone() as LogicPuzzle)!;

        Console.WriteLine("\nState of the copied puzzle...");
        puzzle2.PrintState();
    }
}
