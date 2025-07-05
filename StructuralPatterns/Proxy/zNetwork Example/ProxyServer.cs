using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.zNetwork_Example
{
    public class ProxyServer : Network
    {
        private readonly Network _gateway;

        public ProxyServer()
        {
            _gateway = Gateway.GetInstance();
        }

        public void ftp(string ip, string targetIp)
        {
            Console.WriteLine($"Proxying FTP request from {ip} to {targetIp}");

            filter("ftp", ip, targetIp);

            _gateway.ftp(ip, targetIp); 
        }

        public void telnet(string ip, string targetIp)
        {
            Console.WriteLine($"Proxying Telnet request from {ip} to {targetIp}");

            filter("telnet", ip, targetIp);

            _gateway.telnet(ip, targetIp);
        }

        private void filter(string protocol, string ip, string targetIp)
        {
            if (protocol.Equals("ftp"))
            {
                if(targetIp.StartsWith("192"))
                    throw new YasakKardesimException($"FTP access to {targetIp} is not allowed.\n");
            }

            if (protocol.Equals("telnet"))
            {
                if (targetIp.StartsWith("10"))
                    throw new YasakKardesimException($"Telnet access to {targetIp} is not allowed.\n");
            }
        }
    }
}
