using BuildingBlocks;

namespace AdapterLibrary.BillingSystemExample
{
    public static class BillingSystemExecutor
    {
        /// <summary>
        /// The client code doesn’t get coupled to the concrete adapter class as long as it works with the adapter
        /// via the client interface. Thanks to this, you can introduce new types of adapters into the program without
        /// breaking the existing client code. This can be useful when the interface of the service class gets
        /// changed or replaced: you can just create a new adapter class without changing the client code.
        /// </summary>
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Billing system example");

            HRSystem hrSystem = new HRSystem();
            string[,] employeesInfo = hrSystem.GetEmployeesInfo();

            // Existing HR system wants to process salaries,
            // but since it isn't compatible with third party billing system interface we must use adapter
            ISalaryProcessor salaryProcessor = new HRSystemAdapter();

            salaryProcessor.ProcessSalaries(employeesInfo);
        }
    }
}
