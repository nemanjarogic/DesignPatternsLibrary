using System;
using System.Collections.Generic;
using ProxyLibrary.CachingProxyExample.Common;

namespace ProxyLibrary.CachingProxyExample.ThirdParty
{
    public class ContentStorage
    {
        private readonly Dictionary<int, Video> _videos;

        public ContentStorage()
        {
            _videos = new Dictionary<int, Video>
            {
                { 1, new Video { Id = 1, Content = "Video 1 content" } },
                { 2, new Video { Id = 2, Content = "Video 2 content" } },
                { 3, new Video { Id = 3, Content = "Video 3 content" } },
            };
        }

        public Video GetById(int id)
        {
            Console.WriteLine($"Get content for video with ID: {id} from the content storage...");

            if (!_videos.TryGetValue(id, out Video content))
            {
                throw new Exception($"ID: {id} is unknown to content storage.");
            }

            return content;
        }
    }
}
