using System;
using PrototypeLibrary.DeepCloneExample.Extensions;

namespace PrototypeLibrary.DeepCloneExample.Models
{
    public class MobilePhone
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public OperatingSystem OperatingSystem { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(
                $"\nManufacturer: {Manufacturer}" +
                $"\nModel: {Model}" +
                $"\nOperating system: {OperatingSystem.Name}" +
                $"\nOS version: {OperatingSystem.Version}" +
                $"\nOS description: {OperatingSystem.Description}");
        }

        public MobilePhone Clone()
        {
            return this.DeepClone();
        }
    }
}
