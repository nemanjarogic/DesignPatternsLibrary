using System;
using VisitorLibrary.CompanyExample.Elements.Common;
using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample.Visitors
{
    public class VacationRegulation : IPerformanceReview
    {
        public void Appraise(IEmployeeEvaluation employeeEvaluation)
        {
            var employee = employeeEvaluation as Employee;

            // And because you all helped have such a great year,
            // all my employees get three extra paid time off days each!
            employee.VacationDays += 3;

            Console.WriteLine(
                "{0} {1}'s new vacation days: {2}",
                employee.GetType().Name,
                employee.Name,
                employee.VacationDays);
        }
    }
}
