using DesignPatternsLibrary.PatternExecutors;
using TemplateMethodLibrary.BreadExample;
using TemplateMethodLibrary.ConceptualExample;

namespace TemplateMethodLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Template Method - Behavioral Pattern";

        public override void Execute()
        {
            BreadExecutor.Execute();
            ConceptualExecutor.Execute();
        }
    }
}
