using VisitorLibrary.CompilerExample.Visitors;

namespace VisitorLibrary.CompilerExample.AST
{
    public enum Operator
    {
        Neg,
        Add,
        Sub,
        Mul,
        Div
    };

    public abstract class Expression
    {
        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ConstantExpression : Expression
    {
        public object Value { get; }

        public ConstantExpression(object value)
        {
            Value = value;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public abstract class UnaryExpression : Expression
    {
        public Operator Operator { get; }
        public Expression Expression { get; }

        public UnaryExpression(Expression expression, Operator op)
        {
            Expression = expression;
            Operator = op;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class NegateExpression : UnaryExpression
    {
        public NegateExpression(Expression expression) : base(expression, Operator.Neg)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public abstract class BinaryExpression : Expression
    {
        public Operator Operator { get; }
        public Expression Left { get; }
        public Expression Right { get; }

        public BinaryExpression(Expression left, Expression right, Operator op)
        {
            Operator = op;
            Left = left;
            Right = right;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class AddExpression : BinaryExpression
    {
        public AddExpression(Expression left, Expression right) : base(left, right, Operator.Add)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class SubExpression : BinaryExpression
    {
        public SubExpression(Expression left, Expression right) : base(left, right, Operator.Sub)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class MulExpression : BinaryExpression
    {
        public MulExpression(Expression left, Expression right) : base(left, right, Operator.Sub)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class DivExpression : BinaryExpression
    {
        public DivExpression(Expression left, Expression right) : base(left, right, Operator.Div)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}