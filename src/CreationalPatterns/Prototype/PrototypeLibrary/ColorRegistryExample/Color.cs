using System;
using PrototypeLibrary.ColorRegistryExample.Common;

namespace PrototypeLibrary.ColorRegistryExample
{
    public class Color : IColorPrototype
    {
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public void Customize(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public IColorPrototype Clone()
        {
            Console.WriteLine($"Cloning color RGB: {Red},{Green},{Blue}");

            return MemberwiseClone() as IColorPrototype;
        }
    }
}
