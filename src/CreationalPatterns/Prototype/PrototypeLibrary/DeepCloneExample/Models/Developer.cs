using PrototypeLibrary.DeepCloneExample.Extensions;
using System;

namespace PrototypeLibrary.DeepCloneExample.Models
{
    public class Developer
    {
        public string Name { get; set; }

        public Project Project { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(
                $"Name: {Name}, " +
                $"Projet name: {Project.Name}, " +
                $"Project description: {Project.Description}");
        }

        public Developer Clone()
        {
            return this.DeepClone();
        }
    }
}
