namespace PrototypeLibrary.WebPageScraperExample;

#pragma warning disable IDE0060 // Remove unused parameter
public class WebPageScraper : ICustomCloneable
{
    private string _title = string.Empty;
    private int _numberOfHeaders;
    private int _numberOfPictures;

    public WebPageScraper(string url)
    {
        // var client = new WebClient();
        // var page = client.DownloadString(url);
        Scrape("Fake page");
    }

    public void PrintPageContent() =>
        Console.WriteLine(
            $"Title: {_title}, " +
            $"Number of headers: {_numberOfHeaders}, " +
            $"Number of pictures: {_numberOfPictures} ");

    public WebPageScraper Clone() =>
        // If we have complex data type MemberwiseClone call wouldn't be enough.
        // MemberwiseClone creates a shallow copy of the current object (it goes just one level in the depth).
        (MemberwiseClone() as WebPageScraper)!;

    private void Scrape(string page)
    {
        // Imagine that we need to extract content from the page...

        _title = "Fake title";
        _numberOfHeaders = 3;
        _numberOfPictures = 1;
    }
}
#pragma warning restore IDE0060 // Remove unused parameter
