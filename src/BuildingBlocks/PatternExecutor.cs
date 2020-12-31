namespace DesignPatternsLibrary.PatternExecutors
{
	public abstract class PatternExecutor
	{
		public PatternExecutor()
		{
			Name = GetType().Name;
		}

		public string Name { get; init; }

		public abstract void Execute();
    }
}
