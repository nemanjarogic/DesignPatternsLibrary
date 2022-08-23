using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;
using BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents;

public class Book : Document
{
    public Book(IFormatter formatter)
        : base(formatter)
    {
    }

    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;

    public override void Print()
    {
        Console.WriteLine(_formatter.Format("Title", Title));
        Console.WriteLine(_formatter.Format("Author", Author));
        Console.WriteLine(_formatter.Format("Text", Text));
        Console.WriteLine();
    }
}
