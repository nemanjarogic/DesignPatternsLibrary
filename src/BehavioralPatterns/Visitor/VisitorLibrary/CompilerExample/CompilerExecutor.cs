using BuildingBlocks;
using VisitorLibrary.CompilerExample.AST;
using VisitorLibrary.CompilerExample.Visitors;

namespace VisitorLibrary.CompilerExample
{
    public static class CompilerExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Compiler example");

            var expression = new AddExpression(
                new MulExpression(new ConstantExpression(2), new ConstantExpression(3)),
                new NegateExpression(
                    new DivExpression(new ConstantExpression(6), new ConstantExpression(3))
                )
            );

            ConsoleExtension.WriteSeparator("Expression tree");
            var printer = new PrintExpressionVisitor();
            printer.Visit(expression);

            ConsoleExtension.WriteSeparator("Instructions");
            var emiter = new CodeEmiterVisitor();
            emiter.Visit(expression);
        }
    }
}