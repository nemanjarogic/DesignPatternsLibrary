using System;
using VisitorLibrary.CompanyExample.Elements.Common;
using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample.Visitors
{
    public class IncomeRegulation : IPerformanceReview
    {
        public void Appraise(IEmployeeEvaluation employeeEvaluation)
        {
            var employee = employeeEvaluation as Employee;

            // We've had a great year, so 10% pay raises for everyone!
            // In case that we need different rules for pay raise, we would change IPerformanceReview interface
            // in order to define multiple methods that accept concrete employees (Developer, ProductOwner and ProjectManager).
            employee.AnnualSalary *= 1.10;

            Console.WriteLine(
                "{0} {1}'s new income: {2:C}",
                employee.GetType().Name,
                employee.Name,
                employee.AnnualSalary);
        }
    }
}
