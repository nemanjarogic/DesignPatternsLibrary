using System;
using System.Collections.Generic;

namespace AdapterLibrary.BillingSystemExample
{
    /// <summary>
    /// The Service is some useful class (usually 3rd-party or legacy).
    /// The client can’t use this class directly because it has an incompatible interface.
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"EUR {employee.Salary} salary credited to {employee.Name}'s account.");
            }
        }
    }
}
