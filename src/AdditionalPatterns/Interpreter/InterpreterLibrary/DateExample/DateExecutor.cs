using System;
using System.Collections.Generic;
using BuildingBlocks;
using InterpreterLibrary.DateExample.Expressions.Common;
using InterpreterLibrary.DateExample.Expressions.Terminal;

namespace InterpreterLibrary.DateExample
{
    public static class DateExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Date example");

            // This example doesn't contain non-terminal expressions.
            var expressions = new List<IExpression>
            {
                new DayExpression(),
                new MonthExpression(),
                new YearExpression(),
                new SeparatorExpression(),
            };

            Interpret(expressions, new Context(DateTime.Now, "DD MM YYYY"));
            Interpret(expressions, new Context(DateTime.Now, "YYYY MM DD"));
        }

        private static void Interpret(List<IExpression> expressions, Context context)
        {
            var contextFormat = context.Expression;

            foreach (var expression in expressions)
            {
                expression.Evaluate(context);
            }

            Console.WriteLine($"Interpreter result for {contextFormat} format: {context.Expression}");
        }
    }
}
