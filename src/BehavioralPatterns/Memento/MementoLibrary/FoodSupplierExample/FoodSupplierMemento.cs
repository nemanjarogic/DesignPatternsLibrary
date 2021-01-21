namespace MementoLibrary.FoodSupplierExample
{
    public class FoodSupplierMemento : IMemento
    {
        public FoodSupplierMemento(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
