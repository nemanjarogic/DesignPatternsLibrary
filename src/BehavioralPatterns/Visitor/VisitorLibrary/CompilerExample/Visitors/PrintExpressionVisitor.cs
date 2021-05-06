using System;
using VisitorLibrary.CompilerExample.AST;

namespace VisitorLibrary.CompilerExample.Visitors
{
    public class PrintExpressionVisitor : IVisitor
    {
        private int level = 0;

        private void EnterLevel()
        {
            level++;
        }

        private void ExitLevel()
        {
            if (level > 0)
            {
                level--;
            }
        }

        private void Write(string text)
        {
            var padding = new String(' ', level * 4);
            Console.WriteLine($"{padding}{text}");
        }

        private void Write(Expression node)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Write($"[{node.GetType().Name}]");
            Console.ResetColor();
        }

        public void Visit(Expression node)
        {
            node.Accept(this);
        }

        public void Visit(ConstantExpression node)
        {
            Write(node);
            EnterLevel();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Write($"Value => {node.Value}");
            Console.ResetColor();
            ExitLevel();
        }

        public void Visit(UnaryExpression node)
        {
            Write(node);
            EnterLevel();
            Visit(node.Expression);
            ExitLevel();
        }

        public void Visit(BinaryExpression node)
        {
            Write(node);
            EnterLevel();
            Visit(node.Left);
            Visit(node.Right);
            ExitLevel();
        }
    }
}