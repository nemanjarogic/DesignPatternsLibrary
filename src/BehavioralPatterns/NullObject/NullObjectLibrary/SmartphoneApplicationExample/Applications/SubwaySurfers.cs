using System;
using NullObjectLibrary.ApplicationExample.Applications.Common;

namespace NullObjectLibrary.SmartphoneApplicationExample.Applications
{
    public class SubwaySurfers : Application
    {
        public SubwaySurfers(Guid processId)
            : base(processId)
        {
        }

        public override string Name => "Subway Surfers";
    }
}
