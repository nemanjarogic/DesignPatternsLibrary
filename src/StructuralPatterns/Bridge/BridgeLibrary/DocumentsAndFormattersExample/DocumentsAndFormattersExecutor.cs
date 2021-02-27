using System.Collections.Generic;
using BridgeLibrary.DocumentsAndFormattersExample.Formatters;
using BridgeLibrary.DocumentsAndFormattersExample.Documents;
using BridgeLibrary.DocumentsAndFormattersExample.Documents.Common;
using BuildingBlocks;

namespace BridgeLibrary.DocumentsAndFormattersExample
{
    public static class DocumentsAndFormattersExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Documents and formatters example");

            var documents = new List<Document>();
            var formatter = new FancyFormatter();

            var faq = new FAQ(formatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern.");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");

            var book = new Book(formatter)
            {
                Title = "Head First Design Patterns",
                Author = "Elisabeth Robson & Eric Freeman",
                Text = "Text...",
            };

            var paper = new TermPaper(formatter)
            {
                Class = "Design Patterns",
                Student = "John Doe",
                Text = "Text about design patterns...",
                References = "GOF",
            };

            documents.Add(faq);
            documents.Add(book);
            documents.Add(paper);

            foreach (var document in documents)
            {
                document.Print();
            }
        }
    }
}
