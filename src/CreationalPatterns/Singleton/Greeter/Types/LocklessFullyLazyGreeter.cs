using Greeter.Types.Common;

namespace Greeter.Types
{
    /// <summary>
    /// Instantiation is triggered by the first reference to the static member of the nested class,
    /// which only occurs in Instance property. This means the implementation is fully lazy.
    /// </summary>
    public class LocklessFullyLazyGreeter : BaseGreeter
    {
        private LocklessFullyLazyGreeter()
        {
        }

        public static LocklessFullyLazyGreeter Instance
        {
            get
            {
                return Nested.Instance;
            }
        }

        private class Nested
        {
            /// <summary>
            /// Although nested classes have access to the enclosing class's private members,
            /// the reverse is not true, hence the need for instance to be internal here.
            /// </summary>
            internal static readonly LocklessFullyLazyGreeter Instance = new LocklessFullyLazyGreeter();

            // Explicit static constructor to tell C# compiler not to mark as BeforeFieldInit.
            // http://csharpindepth.com/Articles/General/Singleton.aspx
            static Nested()
            {
            }
        }
    }
}
