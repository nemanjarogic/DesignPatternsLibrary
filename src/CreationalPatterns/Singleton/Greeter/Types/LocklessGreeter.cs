using Greeter.Types.Common;

namespace Greeter.Types
{
    /// <summary>
    /// Why is it thread-safe?
    /// Well, static constructors in C# are specified to execute only when an instance of the class
    /// is created or a static member is referenced, and to execute only once per AppDomain.
    /// Given that this check for the type being newly constructed needs to be executed whatever else happens,
    /// it will be faster than adding extra checking as in the DoubleCheckGreeter example.
    /// There are a couple of wrinkles, however because it's not as lazy as the other implementations.
    /// In particular, if you have static members other than Instance, the first reference to those members will involve
    /// creating the instance. This is corrected in the <see cref="LocklessFullyLazyGreeter"/> implementation.
    /// </summary>
    public class LocklessGreeter : BaseGreeter
    {
        private static readonly LocklessGreeter InstanceValue = new LocklessGreeter();

        // Explicit static constructor to tell C# compiler not to mark type as BeforeFieldInit.
        static LocklessGreeter()
        {
        }

        private LocklessGreeter()
        {
        }

        public static LocklessGreeter Instance
        {
            get
            {
                return InstanceValue;
            }
        }
    }
}
