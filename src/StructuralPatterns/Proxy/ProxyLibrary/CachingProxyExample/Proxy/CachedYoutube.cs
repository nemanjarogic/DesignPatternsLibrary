﻿using ProxyLibrary.CachingProxyExample.Common;
using ProxyLibrary.CachingProxyExample.ThirdParty;

namespace ProxyLibrary.CachingProxyExample.Proxy;

/// <summary>
/// To save some bandwidth, we can cache request results and keep them in memory (for some time).
/// But it may be impossible to put such code directly into the service class.
/// For example, it could have been provided as part of a third party library and/or defined as 'final'.
/// That's why we put the caching code into a new proxy class which implements the same interface as the service class.
/// It delegates to the service object only when the real requests have to be sent.
/// </summary>
public class CachedYoutube : IYoutubeOperations
{
    private readonly Youtube _youtubeService;
    private readonly Dictionary<int, Video> _contentCache;
    private readonly Dictionary<int, VideoMetadata> _metadataCache;

    public CachedYoutube(Youtube youtubeService)
    {
        _youtubeService = youtubeService;

        _contentCache = new Dictionary<int, Video>();
        _metadataCache = new Dictionary<int, VideoMetadata>();
    }

    public Video DownloadVideo(int id)
    {
        if (!_contentCache.TryGetValue(id, out var video))
        {
            video = _youtubeService.DownloadVideo(id);
            _contentCache.Add(video.Id, video);
        }

        return video;
    }

    public VideoMetadata GetVideoMetadata(int id)
    {
        if (!_metadataCache.TryGetValue(id, out var metadata))
        {
            metadata = _youtubeService.GetVideoMetadata(id);
            _metadataCache.Add(metadata.Id, metadata);
        }

        return metadata;
    }

    public IEnumerable<VideoMetadata> ShowHomepage()
    {
        // Naive logic - prepare the homepage using only cached data.
        IEnumerable<VideoMetadata> metadataForHomepage = _metadataCache.Values;

        if (!metadataForHomepage.Any())
        {
            // Nothing is cached on our side yet.
            // Send a network request to the Youtube in order to get enough information for showing the homepage.
            metadataForHomepage = _youtubeService.ShowHomepage();
            foreach (var videoMetadata in metadataForHomepage)
            {
                _metadataCache.Add(videoMetadata.Id, videoMetadata);
            }
        }

        return metadataForHomepage;
    }
}
