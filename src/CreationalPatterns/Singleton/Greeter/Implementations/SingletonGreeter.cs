using Greeter;
using System;

namespace SingletonLibrary.Implementations
{
    public class SingletonGreeter : BaseGreeter
    {
        private static SingletonGreeter instance = null;

        private SingletonGreeter()
        {
            Console.WriteLine("Simple singleton instantiated for the first and only time!");
        }

        public static SingletonGreeter Instance
        {
            get
            {
                Console.WriteLine("Simple singleton being requested...");

                if (instance == null)
                {
                    instance = new SingletonGreeter();
                }

                Console.WriteLine("Simple singleton returned");
                return instance;
            }
        }
    }
}
