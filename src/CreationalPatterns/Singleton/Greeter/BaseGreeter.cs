using System;

namespace Greeter
{
    public abstract class BaseGreeter
    {
        public virtual void Greet()
        {
            Console.WriteLine($"Greetings from {GetType().Name}!");
        }
    }
}
