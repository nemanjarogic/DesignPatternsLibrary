using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Formatters;

public class StandardFormatter : IFormatter
{
    public string Format(string key, string value) =>
        $"{key}: {value}";
}
