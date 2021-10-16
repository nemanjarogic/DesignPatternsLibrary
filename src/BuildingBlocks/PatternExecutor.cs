namespace DesignPatternsLibrary.PatternExecutors
{
    /// <summary>
    /// Every design pattern example should have an executor class
    /// that inherits from <see cref="PatternExecutor"/>.
    /// </summary>
    public abstract class PatternExecutor
    {
        /// <summary>
        /// Gets name.
        /// </summary>
        public virtual string Name => GetType().Name;

        /// <summary>
        /// The Execute method is the entry point of an executable design pattern example.
        /// When an arbitrary design pattern example is chosen from the command menu,
        /// the Execute method is the first method that is invoked.
        /// </summary>
        public abstract void Execute();
    }
}
