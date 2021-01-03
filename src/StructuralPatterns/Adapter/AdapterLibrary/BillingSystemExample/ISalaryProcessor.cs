namespace AdapterLibrary.BillingSystemExample
{
    /// <summary>
    /// The Client Interface describes a protocol that other classes must follow to be able to collaborate with the client code.
    /// </summary>
    public interface ISalaryProcessor
    {
        void ProcessSalaries(string[,] employees);
    }
}
