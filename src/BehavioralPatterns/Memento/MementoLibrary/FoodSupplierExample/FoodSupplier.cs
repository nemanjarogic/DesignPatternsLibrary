using System;

namespace MementoLibrary.FoodSupplierExample
{
    public class FoodSupplier
    {
        private string _name;
        private string _phone;
        private string _address;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                Console.WriteLine($"Food supplier: Name is set to {_name}");
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                Console.WriteLine($"Food supplier: Phone Number is set to {_phone}");
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                Console.WriteLine($"Food supplier: Address is set to {_address}");
            }
        }

        public IMemento Save()
        {
            Console.WriteLine("\nFood supplier: Saving current state...");
            return new FoodSupplierMemento(_name, _phone, _address);
        }

        /// <summary>
        /// Restore previous state.
        /// Note that the method returns an IMemento instance in order to to facilitate redo operation.
        /// The return type can be changed to void if redo doesn't have to be supported.
        /// </summary>
        /// <param name="memento">Memento for restoration.</param>
        /// <returns>Redo memento.</returns>
        public IMemento Restore(IMemento memento)
        {
            Console.WriteLine("\nFood supplier: Restoring state...");

            if (memento is not FoodSupplierMemento foodSupplierMemento)
            {
                throw new Exception($"Unknown memento: {memento}");
            }

            var redoMemento = new FoodSupplierMemento(_name, _phone, _address);

            Name = foodSupplierMemento.Name;
            Phone = foodSupplierMemento.PhoneNumber;
            Address = foodSupplierMemento.Address;

            return redoMemento;
        }
    }
}
