using DesignPatternsLibrary.PatternExecutors;
using MementoLibrary.ConceptualExample;
using MementoLibrary.FoodSupplierExample;

namespace MementoLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Memento - Behavioral Pattern";

        public override void Execute()
        {
            ConceptualExecutor.Execute();
            FoodSupplierExecutor.Execute();
        }
    }
}
