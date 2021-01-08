using System.Collections.Generic;
using ProxyLibrary.CachingProxyExample.Common;

namespace ProxyLibrary.CachingProxyExample.ThirdParty
{
    /// <summary>
    /// The concrete implementation of a service connector.
    /// Methods of this class can request information from YouTube.
    /// The speed of the request depends on a user's internet connection as well as YouTube's.
    /// The application will slow down if a lot of requests are fired at the same time,
    /// even if they all request the same information.
    /// </summary>
    public class Youtube : IYoutubeOperations
    {
        private readonly ContentStorage _contentStorage = new ContentStorage();
        private readonly MetadataStorage _metadataStorage = new MetadataStorage();

        public Video DownloadVideo(int id)
        {
            return _contentStorage.GetById(id);
        }

        public VideoMetadata GetVideoMetadata(int id)
        {
            return _metadataStorage.GetById(id);
        }

        public IEnumerable<VideoMetadata> ShowHomepage()
        {
            return _metadataStorage.GetAll();
        }
    }
}
