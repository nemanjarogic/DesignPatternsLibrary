using System.Collections.Generic;
using VisitorLibrary.CompanyExample.Elements.Common;
using VisitorLibrary.CompanyExample.Visitors.Common;

namespace VisitorLibrary.CompanyExample
{
    public class Company
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Hire(Employee employee)
        {
            _employees.Add(employee);
        }

        public void LayOff(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void ReviewEmployeesAtEndOfTheYear(IPerformanceReview performanceReview)
        {
            foreach (Employee employee in _employees)
            {
                employee.Evaluate(performanceReview);
            }
        }
    }
}
