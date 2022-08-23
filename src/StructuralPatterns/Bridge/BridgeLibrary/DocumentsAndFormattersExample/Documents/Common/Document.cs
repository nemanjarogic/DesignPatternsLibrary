using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;

public abstract class Document
{
    protected readonly IFormatter _formatter;

    protected Document(IFormatter formatter)
    {
        _formatter = formatter;
    }

    public abstract void Print();
}
