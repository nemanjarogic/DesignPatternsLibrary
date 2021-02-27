using System;
using System.Linq;
using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Formatters
{
    public class BackwardsFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, new string(value.Reverse().ToArray()));
        }
    }
}
