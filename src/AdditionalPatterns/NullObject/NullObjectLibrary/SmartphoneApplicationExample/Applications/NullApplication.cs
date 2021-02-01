using System;
using NullObjectLibrary.ApplicationExample.Applications.Common;

namespace NullObjectLibrary.SmartphoneApplicationExample.Applications
{
    public class NullApplication : Application
    {
        public NullApplication()
            : base(Guid.Empty)
        {
        }

        public override string Name => string.Empty;

        public override void Open()
        {
        }

        public override void Close()
        {
        }
    }
}
