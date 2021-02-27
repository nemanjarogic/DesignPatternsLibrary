using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Formatters
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, value);
        }
    }
}
