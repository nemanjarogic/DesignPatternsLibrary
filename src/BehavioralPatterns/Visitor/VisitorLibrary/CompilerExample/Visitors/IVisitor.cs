using VisitorLibrary.CompilerExample.AST;

namespace VisitorLibrary.CompilerExample.Visitors
{
    public interface IVisitor
    {
        void Visit(Expression node);

        void Visit(ConstantExpression node);

        void Visit(UnaryExpression node);

        void Visit(BinaryExpression node);
    }
}