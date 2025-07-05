using Proxy.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProxyObject
{
    public class CachedYouTubeClass : IThirdPartyYouTubeLib
    {
        private readonly IThirdPartyYouTubeLib _service;

        private List<string>? _cachedVideos;
        private Dictionary<string, string> _cachedVideoInfo;
        private Dictionary<string, bool> _cachedDownloads;

        public CachedYouTubeClass(IThirdPartyYouTubeLib service)
        {
            _service = service;
            _cachedVideos = null;
            _cachedVideoInfo = new Dictionary<string, string>();
            _cachedDownloads = new Dictionary<string, bool>();
        }

        public void downloadVideo(string id)
        {
            if (!_cachedDownloads.ContainsKey(id))
            {
                Console.WriteLine($"Cache miss: Downloading video {id}...");
                _service.downloadVideo(id);
                _cachedDownloads[id] = true;
            }
            else
            {
                Console.WriteLine($"Cache hit: Video {id} already downloaded...");
            }
        }

        public string getVideoInfo(string id)
        {
            if (!_cachedVideoInfo.ContainsKey(id))
            {
                Console.WriteLine($"Cache miss: Fetching info for video {id}...");
                _cachedVideoInfo[id] = _service.getVideoInfo(id);
            }
            else
            {
                Console.WriteLine($"Cache hit: Returning cached info for video {id}...");
            }
            return _cachedVideoInfo[id];
        }

        public List<string> listVideos()
        {
            if (_cachedVideos == null)
            {
                Console.WriteLine("Cache miss: Fetching video list...");
                _cachedVideos = _service.listVideos();
            }
            else
            {
                Console.WriteLine("Cache hit: Returning cached video list...");
            }
            return _cachedVideos;
        }
    }
}
