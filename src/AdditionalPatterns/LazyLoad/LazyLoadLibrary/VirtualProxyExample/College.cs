namespace LazyLoadLibrary.VirtualProxyExample;

public class College
{
    public int Id { get; init; }

    public virtual Library? Library { get; set; }

    public void ShowDetails() =>
        Console.WriteLine(
            $"College library with {Library!.NumberOfBooks} books " +
            $"was established on {Library.EstablishmentDate.ToShortDateString()}.");
}
