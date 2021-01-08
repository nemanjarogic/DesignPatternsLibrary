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
        public override string Name => "Prototype - Prototype Library - Creational Pattern";

        public override void Execute()
        {
            ComplexUnstableObjectExecutor.Execute();
            ColorRegistryExecutor.Execute();
            DeepCloneExecutor.Execute();
            LogicPuzzleExecutor.Execute();
            WebPageScraperExecutor.Execute();
        }
    }
}
