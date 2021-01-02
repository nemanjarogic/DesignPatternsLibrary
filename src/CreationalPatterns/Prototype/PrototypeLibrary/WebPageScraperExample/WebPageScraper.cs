using System;

namespace PrototypeLibrary.WebPageScraperExample
{
    public class WebPageScraper : ICloneable
    {
        private string _title;
        private int _numberOfHeaders;
        private int _numberOfPictures;

        public WebPageScraper(string url)
        {
            // var client = new WebClient();
            // var page = client.DownloadString(url);
            Scrape("Fake page");
        }

        public void PrintPageContent()
        {
            Console.WriteLine(
                $"Title: {_title}, " +
                $"Number of headers: {_numberOfHeaders}, " +
                $"Number of pictures: {_numberOfPictures} ");
        }

        public object Clone()
        {
            // If we had complex data type MemberwiseClone call wouldn't be enough.
            // MemberwiseClone creates a shallow copy of the current object (it goes just one level in depth)
            return MemberwiseClone();
        }

        private void Scrape(string page)
        {
            _title = "Fake title";
            _numberOfHeaders = 3;
            _numberOfPictures = 1;
        }
    }
}
