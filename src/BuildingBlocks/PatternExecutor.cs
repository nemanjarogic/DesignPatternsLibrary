namespace DesignPatternsLibrary.PatternExecutors
{
	public abstract class PatternExecutor
	{
		public PatternExecutor(string name = "")
		{
			Name = string.IsNullOrWhiteSpace(name) ? GetType().Name : name;
		}

		public string Name { get; init; }

		public abstract void Execute();
    }
}
