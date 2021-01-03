using System;
using System.Collections.Generic;

namespace AdapterLibrary.BillingSystemExample
{
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

            for (int i = 0; i < rawEmployees.GetLength(0); i++)
            {
                string id = null;
                string name = null;
                string salary = null;

                for (int j = 0; j < rawEmployees.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        id = rawEmployees[i, j];
                    }
                    else if (j == 1)
                    {
                        name = rawEmployees[i, j];
                    }
                    else
                    {
                        salary = rawEmployees[i, j];
                    }
                }

                var employee = new Employee
                {
                    Id = Convert.ToInt32(id),
                    Name = name,
                    Salary = Convert.ToDecimal(salary),
                };

                employeesForProcessing.Add(employee);
            }

            Console.WriteLine("Adapter converted array of employees to list of employees...");

            return employeesForProcessing;
        }
    }
}
