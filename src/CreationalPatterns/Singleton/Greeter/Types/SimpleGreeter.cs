using System;
using Greeter.Types.Common;

namespace Greeter.Types
{
    /// <summary>
    /// Simple singleton that is not thread-safe.
    /// Two different threads could both have evaluated the test if (instance == null) and found it to be true,
    /// then both create instances, which violates the singleton pattern.
    /// </summary>
    public class SimpleGreeter : BaseGreeter
    {
        private static SimpleGreeter _instance;

        private SimpleGreeter()
        {
            Console.WriteLine("Simple singleton instantiated for the first and only time!");
        }

        public static SimpleGreeter Instance
        {
            get
            {
                Console.WriteLine("Simple singleton being requested...");

                if (_instance == null)
                {
                    _instance = new SimpleGreeter();
                }

                Console.WriteLine("Simple singleton returned");
                return _instance;
            }
        }
    }
}
