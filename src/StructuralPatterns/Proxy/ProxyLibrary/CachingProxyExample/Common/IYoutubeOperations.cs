using System.Collections.Generic;

namespace ProxyLibrary.CachingProxyExample.Common
{
    /// <summary>
    /// The interface of a remote service.
    /// </summary>
    public interface IYoutubeOperations
    {
        VideoMetadata GetVideoMetadata(int id);

        Video DownloadVideo(int id);

        IEnumerable<VideoMetadata> ShowHomepage();
    }
}
