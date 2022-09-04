using BuildingBlocks;
using VisitorLibrary.CompanyExample.Elements;
using VisitorLibrary.CompanyExample.Visitors;

namespace VisitorLibrary.CompanyExample;

public static class CompanyExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Company example");

        var company = new Company();
        company.Hire(new Developer());
        company.Hire(new ProductOwner());
        company.Hire(new ProjectManager());

        Console.WriteLine("\nIt's time for annual performance reviews...\n");

        Console.WriteLine("\nStarting review for the income regulation...\n");
        company.ReviewEmployeesAtEndOfTheYear(new IncomeRegulation());

        Console.WriteLine("\nStarting review for the vacation regulation...\n");
        company.ReviewEmployeesAtEndOfTheYear(new VacationRegulation());
    }
}
