using System;

namespace InterpreterLibrary.DateExample
{
    public class Context
    {
        public Context(DateTime date, string expression)
        {
            Date = date;
            Expression = expression;
        }

        public DateTime Date { get; set; }

        public string Expression { get; set; }
    }
}
