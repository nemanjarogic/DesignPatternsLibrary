using BuildingBlocks;

namespace AdapterLibrary.BillingSystemExample;

public static class BillingSystemExecutor
{
    /// <summary>
    /// The client code doesn't get coupled to the concrete adapter class as long as it works with the adapter via the client interface.
    /// Thanks to this, you can introduce new types of adapters into the program without breaking the existing client code.
    /// This can be useful when the interface of the service class gets changed or replaced:
    /// you can just create a new adapter class without changing the client code.
    /// </summary>
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Billing system example");

        HRSystem hrSystem = new HRSystem();
        string[,] employeesInfo = hrSystem.GetEmployeesInfo();

        // Existing HR system wants to process salaries,
        // but since it isn't compatible with the 3rd party billing system interface we must use adapter.
        // The 3rd party billing system expects List<Employee>, but the current HR system works only with string[,].
        // Hide that using adapter design pattern (note that the client is not aware of what's happening under the hood).
        // The client code doesn't get coupled to the concrete adapter class as long as it works with the adapter via the interface.
        // In this case the client is coupled with the concrete adapter class only because we don't use dependency injection for demo purposes.
        ISalaryProcessor salaryProcessor = new HRSystemAdapter();
        salaryProcessor.ProcessSalaries(employeesInfo);
    }
}
