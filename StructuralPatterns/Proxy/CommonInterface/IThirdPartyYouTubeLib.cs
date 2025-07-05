using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.CommonInterface
{
    public interface IThirdPartyYouTubeLib
    {
        List<string> listVideos();
        string getVideoInfo(string id);
        void downloadVideo(string id);
    }
}
