using BuildingBlocks;

namespace PrototypeLibrary.WebPageScraperExample
{
    public static class WebPageScraperExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Web page scraper example");

            var scraper = new WebPageScraper("https://www.pluralsight.com/");
            scraper.PrintPageContent();

            // There is no need for two identical call, if we just want to copy object data
            // var scraper2 = new WebPageScraper("https://www.pluralsight.com/");
            // scraper.PrintPageContent();

            // After implementing of ICloneable, we can call Clone().
            // This is basically prototype pattern.
            var scraper3 = scraper.Clone() as WebPageScraper;
            scraper3.PrintPageContent();
        }
    }
}
