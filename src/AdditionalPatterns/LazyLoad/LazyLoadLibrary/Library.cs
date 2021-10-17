using System;

namespace LazyLoadLibrary
{
    public class Library
    {
        public Library()
        {
            Console.WriteLine("Loading library...");

            Name = "Library";
            EstablishmentDate = new DateTime(2012, 5, 25);
            Address = "3537 Wood Street, Saginaw";
            NumberOfBooks = 10000;
        }

        public string Name { get; set; }

        public DateTime EstablishmentDate { get; set; }

        public string Address { get; set; }

        public int NumberOfBooks { get; set; }
    }
}
