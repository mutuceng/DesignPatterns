using Proxy.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.RealObject
{
    public class ThirdPartyYouTubeClass : IThirdPartyYouTubeLib
    {
        public void downloadVideo(string id)
        {
            Console.WriteLine($"Downloading video {id} from third-party service...");
        }

        public string getVideoInfo(string id)
        {
            Console.WriteLine($"Fetching info for video {id} from third-party service...");
            return $"Info for {id}";
        }

        public List<string> listVideos()
        {
            Console.WriteLine("Fetching video list from third-party service...");
            return new List<string> { "video1", "video2", "video3" };
        }
    }
}
