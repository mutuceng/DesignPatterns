using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.zNetwork_Example
{
    public interface Network
    {
        public void telnet(string ip, string targetIp);
        public void ftp(string ip, string targetIp);
    }
}
