using DesignPatternsLibrary.PatternExecutors;
using IteratorLibrary.ConceptualExample;
using IteratorLibrary.MusicFestivalsExample;

namespace IteratorLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Iterator - Behavioral Pattern";

        public override void Execute()
        {
            ConceptualExecutor.Execute();
            MusicFestivalsExecutor.Execute();
        }
    }
}
