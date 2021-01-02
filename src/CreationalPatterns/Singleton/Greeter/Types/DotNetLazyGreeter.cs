using System;
using Greeter.Types.Common;

namespace Greeter.Types
{
    /// <summary>
    /// If you're using .NET 4 (or higher), you can use the Lazy<T> type to make the laziness really simple.
    /// It also allows you to check whether or not the instance
    /// has been created yet with the IsValueCreated property, if you need that.
    /// This code implicitly uses LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode.
    /// Depending on your requirements, you may wish to experiment with other modes.
    /// </summary>
    public class DotNetLazyGreeter : BaseGreeter
    {
        private static readonly Lazy<DotNetLazyGreeter> Lazy = new Lazy<DotNetLazyGreeter>(() => new DotNetLazyGreeter());

        private DotNetLazyGreeter()
        {
        }

        public static DotNetLazyGreeter Instance
        {
            get
            {
                return Lazy.Value;
            }
        }
    }
}
