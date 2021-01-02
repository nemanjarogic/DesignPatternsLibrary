using System;

namespace Greeter.Types.Common
{
    public abstract class BaseGreeter
    {
        public virtual void Greet()
        {
            Console.WriteLine($"Greetings from {GetType().Name}!");
        }
    }
}
