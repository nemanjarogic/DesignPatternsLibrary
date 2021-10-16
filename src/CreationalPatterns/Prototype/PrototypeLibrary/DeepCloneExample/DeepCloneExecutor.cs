using BuildingBlocks;
using PrototypeLibrary.DeepCloneExample.Models;

namespace PrototypeLibrary.DeepCloneExample
{
    public static class DeepCloneExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Deep clone example");

            var phone = new MobilePhone
            {
                Manufacturer = "Xiaomi",
                Model = "11T",
                OperatingSystem = new OperatingSystem
                {
                    Name = "Android",
                    Version = "11",
                    Description = "Android is a mobile OS based on a modified version of the Linux kernel and other open source software, designed primarily for touchscreen mobile devices such as smartphones and tablets. ",
                },
            };

            var clonedPhone = phone.Clone();
            clonedPhone.Model = "11T Pro";

            phone.PrintDetails();
            clonedPhone.PrintDetails();
        }
    }
}
