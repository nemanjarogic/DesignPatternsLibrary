using System;
using NullObjectLibrary.ApplicationExample.Applications.Common;

namespace NullObjectLibrary.SmartphoneApplicationExample.Applications
{
    public class Gmail : Application
    {
        public Gmail(Guid processId)
            : base(processId)
        {
        }

        public override string Name => "Gmail";
    }
}
