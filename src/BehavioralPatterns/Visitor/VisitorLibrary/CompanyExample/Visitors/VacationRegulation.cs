using VisitorLibrary.CompanyExample.Elements.Common;
using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample.Visitors;

public class VacationRegulation : IPerformanceReview
{
    public void Appraise(IEmployeeEvaluation employeeEvaluation)
    {
        if (employeeEvaluation is not Employee employee)
        {
            throw new ArgumentException("Appraise method works only with Employee objects");
        }

        // And because you all helped have such a great year,
        // all employees will get three extra paid time off days!
        employee.VacationDays += 3;

        Console.WriteLine(
            "{0} {1}'s new vacation days: {2}",
            employee.GetType().Name,
            employee.Name,
            employee.VacationDays);
    }
}
