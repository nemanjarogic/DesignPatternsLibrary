using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;
using BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents;

public class TermPaper : Document
{
    public TermPaper(IFormatter formatter)
        : base(formatter)
    {
    }

    public string Class { get; set; } = string.Empty;
    public string Student { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string References { get; set; } = string.Empty;

    public override void Print()
    {
        Console.WriteLine(_formatter.Format("Class", Class));
        Console.WriteLine(_formatter.Format("Student", Student));
        Console.WriteLine(_formatter.Format("Text", Text));
        Console.WriteLine(_formatter.Format("References", References));
        Console.WriteLine();
    }
}
