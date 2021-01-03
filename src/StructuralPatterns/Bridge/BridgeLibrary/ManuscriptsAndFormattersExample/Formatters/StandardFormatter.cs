using BridgeLibrary.ManuscriptsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.ManuscriptsAndFormattersExample.Formatters
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, value);
        }
    }
}
