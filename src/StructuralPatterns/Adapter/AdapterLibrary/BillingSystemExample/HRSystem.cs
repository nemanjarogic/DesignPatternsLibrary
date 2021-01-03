namespace AdapterLibrary.BillingSystemExample
{
    /// <summary>
    /// This class contains the functionality which the client requires,
    /// but it’s not compatible with the existing client code.
    /// So, it requires some adaptation before the client code can use it.
    /// </summary>
    public class HRSystem
    {
        public string[,] GetEmployeesInfo()
        {
            return new string[4, 3]
            {
                { "1", "John", "5950" },
                { "2", "Anna", "5800" },
                { "3", "Nicole", "6100" },
                { "4", "Steven", "5000" },
            };
        }
    }
}
