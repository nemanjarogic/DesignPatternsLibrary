namespace LazyLoadLibrary;

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

    public string Name { get; }
    public DateTime EstablishmentDate { get; }
    public string Address { get; }
    public int NumberOfBooks { get; }
}
