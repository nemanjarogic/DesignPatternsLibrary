namespace RulesLibrary.Common;

public class Customer
{
    public Customer(DateTime dateOfBirth, bool isVeteran, DateTime? dateOfFirstPurchase = null)
    {
        DateOfBirth = dateOfBirth;
        IsVeteran = isVeteran;
        DateOfFirstPurchase = dateOfFirstPurchase;
    }
    public DateTime DateOfBirth { get; }
    public DateTime? DateOfFirstPurchase { get; }
    public bool IsVeteran { get; }
}
