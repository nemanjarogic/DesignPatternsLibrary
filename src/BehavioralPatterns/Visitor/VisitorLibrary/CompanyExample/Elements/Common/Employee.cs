using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample.Elements.Common;

public class Employee : IEmployeeEvaluation
{
    public Employee(string name, double annualSalary, int vacationDays)
    {
        Name = name;
        AnnualSalary = annualSalary;
        VacationDays = vacationDays;

        Console.WriteLine(
            "{0} {1} has annual salary of {2:C} and {3} vacation days",
            GetType().Name,
            Name,
            AnnualSalary,
            VacationDays);
    }

    public string Name { get; set; }
    public double AnnualSalary { get; set; }
    public int VacationDays { get; set; }

    public void Evaluate(IPerformanceReview performanceReview) =>
        performanceReview.Appraise(this);
}
