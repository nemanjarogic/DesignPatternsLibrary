using PrototypeLibrary.DeepCloneExample.Extensions;

namespace PrototypeLibrary.DeepCloneExample.Models;

public class MobilePhone
{
    public string Manufacturer { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public OperatingSystem OperatingSystem { get; set; } = new();

    public void PrintDetails() =>
        Console.WriteLine(
            $"\nManufacturer: {Manufacturer}" +
            $"\nModel: {Model}" +
            $"\nOperating system: {OperatingSystem.Name}" +
            $"\nOS version: {OperatingSystem.Version}" +
            $"\nOS description: {OperatingSystem.Description}");

    public MobilePhone Clone() => this.DeepClone();
}
