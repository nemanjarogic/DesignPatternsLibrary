using System;
using NullObjectLibrary.SmartphoneApplicationExample.Applications;

namespace NullObjectLibrary.ApplicationExample.Applications.Common
{
    public abstract class Application
    {
        private static readonly NullApplication NullApplication = new NullApplication();

        public Application(Guid processId)
        {
            ProcessId = processId;
        }

        public static NullApplication Default
        {
            get
            {
                return NullApplication;
            }
        }

        public abstract string Name { get; }

        public Guid ProcessId { get; }

        public virtual void Open()
        {
            Console.WriteLine($"{Name} opened.");
        }

        public virtual void Close()
        {
            Console.WriteLine($"{Name} closed.");
        }
    }
}
