using System;
using ProxyLibrary.CachingProxyExample.Common;

namespace ProxyLibrary.CachingProxyExample
{
    /// <summary>
    /// The client class, which used to work directly with a service object,
    /// stays unchanged as long as it works with the service object through an interface.
    /// We can safely pass a proxy object instead of a real service object since
    /// they both implement the same interface.
    /// </summary>
    public class YoutubeManager
    {
        private readonly IYoutubeOperations _youtube;

        public YoutubeManager(IYoutubeOperations youtube)
        {
            _youtube = youtube;
        }

        public void RenderHomepage()
        {
            Console.WriteLine("\nRendering homepage...");

            foreach (var homepageItem in _youtube.ShowHomepage())
            {
                Console.WriteLine($"Video with name: '{homepageItem.Name}' and description: '{homepageItem.Description}'");
            }
        }

        public void PlayVideo(int id)
        {
            Console.WriteLine("\nPlaying video...");

            var video = _youtube.DownloadVideo(id);
            Console.WriteLine($"Streaming started... Content: {video.Content}");

            var metadata = _youtube.GetVideoMetadata(id);
            Console.WriteLine($"Metadata loaded...Name: '{metadata.Name}' and description: '{metadata.Description}'");
        }
    }
}
