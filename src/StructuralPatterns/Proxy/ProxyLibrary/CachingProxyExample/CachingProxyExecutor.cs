using BuildingBlocks;
using ProxyLibrary.CachingProxyExample.Proxy;
using ProxyLibrary.CachingProxyExample.ThirdParty;

namespace ProxyLibrary.CachingProxyExample
{
    public static class CachingProxyExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Caching proxy example");

            var youtubeService = new Youtube();
            var cachedYoutubeService = new CachedYoutube(youtubeService);

            var youtubeManager = new YoutubeManager(cachedYoutubeService);

            youtubeManager.PlayVideo(1);
            youtubeManager.PlayVideo(2);

            // Video 1 should be cached.
            // Request to third party service will not be issued.
            youtubeManager.PlayVideo(1);
        }
    }
}
