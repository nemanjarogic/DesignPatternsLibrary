using DesignPatternsLibrary.PatternExecutors;
using PrototypeLibrary.ColorRegistryExample;
using PrototypeLibrary.ComplexUnstableObjectExample;
using PrototypeLibrary.DeepCloneExample;
using PrototypeLibrary.LogicPuzzleExample;
using PrototypeLibrary.WebPageScraperExample;

namespace PrototypeLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Prototype - Creational Pattern";

        public override void Execute()
        {
            ColorRegistryExecutor.Execute();
            ComplexUnstableObjectExecutor.Execute();
            DeepCloneExecutor.Execute();
            LogicPuzzleExecutor.Execute();
            WebPageScraperExecutor.Execute();
        }
    }
}
