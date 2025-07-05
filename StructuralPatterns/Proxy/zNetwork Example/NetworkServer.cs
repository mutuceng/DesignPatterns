using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Proxy.zNetwork_Example
{
    public class NetworkServer 
    {
        private static readonly NetworkServer _ns = new NetworkServer();

        private readonly Network _network;

        private NetworkServer()
        {
            _network = new ProxyServer();
        }

        public static NetworkServer GetInstance()
        {
            return _ns;
        }

        public Network GetNetwork()
        {
            return _network;
        }

    }
}
