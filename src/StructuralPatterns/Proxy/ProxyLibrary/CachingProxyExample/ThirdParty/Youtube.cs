using ProxyLibrary.CachingProxyExample.Common;

namespace ProxyLibrary.CachingProxyExample.ThirdParty;

/// <summary>
/// The concrete implementation of a service connector.
/// Methods of this class can request information from YouTube.
/// The speed of the request depends on a user's internet connection as well as YouTube's.
/// The application will slow down if a lot of requests are fired at the same time,
/// even if they all request the same information.
/// </summary>
public class Youtube : IYoutubeOperations
{
    private readonly ContentStorage _contentStorage = new();
    private readonly MetadataStorage _metadataStorage = new();

    public Video DownloadVideo(int id) => _contentStorage.GetById(id);

    public VideoMetadata GetVideoMetadata(int id) => _metadataStorage.GetById(id);

    public IEnumerable<VideoMetadata> ShowHomepage() => _metadataStorage.GetAll();
}
