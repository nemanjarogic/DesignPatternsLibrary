using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Formatters;

public class BackwardsFormatter : IFormatter
{
    public string Format(string key, string value) =>
        $"{key}: {new string(value.Reverse().ToArray())}";
}
