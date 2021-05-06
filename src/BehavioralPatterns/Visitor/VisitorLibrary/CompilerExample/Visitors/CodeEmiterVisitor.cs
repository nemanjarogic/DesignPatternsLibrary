using System;
using VisitorLibrary.CompilerExample.AST;

namespace VisitorLibrary.CompilerExample.Visitors
{
    public class CodeEmiterVisitor : IVisitor
    {
        private void Write(string text)
        {
            Console.WriteLine(text);
        }

        public void Visit(Expression node)
        {
            node.Accept(this);
        }

        public void Visit(ConstantExpression node)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Write($"PushConst {node.Value}");
            Console.ResetColor();
        }

        public void Visit(UnaryExpression node)
        {
            Visit(node.Expression);
            Console.ForegroundColor = ConsoleColor.Red;
            Write(node.Operator.ToString());
            Console.ResetColor();
        }

        public void Visit(BinaryExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
            Console.ForegroundColor = ConsoleColor.Blue;
            Write(node.Operator.ToString());
            Console.ResetColor();
        }
    }
}