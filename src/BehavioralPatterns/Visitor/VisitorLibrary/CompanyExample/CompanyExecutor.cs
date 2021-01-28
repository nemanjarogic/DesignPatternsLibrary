using System;
using BuildingBlocks;
using VisitorLibrary.CompanyExample.Elements;
using VisitorLibrary.CompanyExample.Visitors;

namespace VisitorLibrary.CompanyExample
{
    public static class CompanyExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Company example");

            var company = new Company();
            company.Hire(new Developer());
            company.Hire(new ProductOwner());
            company.Hire(new ProjectManager());

            company.ReviewEmployeesAtEndOfTheYear(new IncomeRegulation());

            Console.WriteLine("\nStarting second phase of performance review...\n");

            company.ReviewEmployeesAtEndOfTheYear(new VacationRegulation());
        }
    }
}
