using System;
using BridgeLibrary.DocumentsAndFormattersExample.Formatters.Common;
using BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;

namespace BridgeLibrary.DocumentsAndFormattersExample.Documents
{
    public class Book : Document
    {
        public Book(IFormatter formatter)
            : base(formatter)
        {
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}
