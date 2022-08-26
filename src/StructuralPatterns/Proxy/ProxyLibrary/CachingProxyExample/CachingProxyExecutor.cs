using BuildingBlocks;
using ProxyLibrary.CachingProxyExample.Manager;
using ProxyLibrary.CachingProxyExample.Proxy;
using ProxyLibrary.CachingProxyExample.ThirdParty;

namespace ProxyLibrary.CachingProxyExample;

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
        // Therefore, a request to the third party service shouldn't be issued.
        youtubeManager.PlayVideo(1);
    }
}
