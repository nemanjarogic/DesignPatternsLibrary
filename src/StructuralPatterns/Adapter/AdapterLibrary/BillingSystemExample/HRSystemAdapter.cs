using System.Globalization;

namespace AdapterLibrary.BillingSystemExample;

/// <summary>
/// This is a class which makes two incompatible systems to work together.
/// The Adapter is a class that’s able to work with both the client and the service:
/// it implements the client interface, while wrapping the service object.
/// The adapter receives calls from the client via the adapter interface and translates them
/// into calls to the wrapped service object in a format it can understand.
/// </summary>
public class HRSystemAdapter : ISalaryProcessor
{
    private readonly ThirdPartyBillingSystem _thirdPartyBillingSystem;

    public HRSystemAdapter()
    {
        _thirdPartyBillingSystem = new ThirdPartyBillingSystem();
    }

    public void ProcessSalaries(string[,] rawEmployees)
    {
        var employeesForProcessing = PrepareEmployeesForSalaryProcessing(rawEmployees);
        _thirdPartyBillingSystem.ProcessSalary(employeesForProcessing);
    }

    private List<Employee> PrepareEmployeesForSalaryProcessing(string[,] rawEmployees)
    {
        var employeesForProcessing = new List<Employee>();

        for (var i = 0; i < rawEmployees.GetLength(0); i++)
        {
            var id = string.Empty;
            var name = string.Empty;
            var salary = string.Empty;

            for (var j = 0; j < rawEmployees.GetLength(1); j++)
            {
                switch (j)
                {
                    case 0:
                        id = rawEmployees[i, j];
                        break;
                    case 1:
                        name = rawEmployees[i, j];
                        break;
                    default:
                        salary = rawEmployees[i, j];
                        break;
                }
            }

            var employee = new Employee
            {
                Id = Convert.ToInt32(id, CultureInfo.InvariantCulture),
                Name = name,
                Salary = Convert.ToDecimal(salary, CultureInfo.InvariantCulture),
            };
            employeesForProcessing.Add(employee);
        }

        Console.WriteLine("Adapter converted array of employees to list of employees...");

        return employeesForProcessing;
    }
}
