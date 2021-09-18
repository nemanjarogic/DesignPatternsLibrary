using Greeter.Types.Common;

namespace Greeter.Types
{
    /// <summary>
    /// This implementation attempts to be thread-safe without the necessity of taking out a lock every time.
    /// However, it's easy to get wrong. The pattern needs to be pretty much exactly as above - any significant changes
    /// are likely to impact either performance or correctness.
    /// It doesn't perform as well as the <see cref="LocklessGreeter"/> or <see cref="LocklessFullyLazyGreeter"/>.
    /// </summary>
    public class DoubleCheckGreeter : BaseGreeter
    {
        private static readonly object Padlock = new object();

        private static DoubleCheckGreeter _instance;

        private DoubleCheckGreeter()
        {
        }

        /// <summary>
        /// Gets instance in a way to support multithreaded applications through 'double checked locking'
        /// pattern which (once the instance exists) avoids locking each time the method is invoked.
        /// </summary>
        public static DoubleCheckGreeter Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckGreeter();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
