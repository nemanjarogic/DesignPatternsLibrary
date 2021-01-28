using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample.Elements.Common
{
    public class Employee : IEmployeeEvaluation
    {
        public Employee(string name, double annualSalary, int vacationDays)
        {
            Name = name;
            AnnualSalary = annualSalary;
            VacationDays = vacationDays;
        }

        public string Name { get; set; }

        public double AnnualSalary { get; set; }

        public int VacationDays { get; set; }

        public void Evaluate(IPerformanceReview performanceReview)
        {
            performanceReview.Appraise(this);
        }
    }
}
