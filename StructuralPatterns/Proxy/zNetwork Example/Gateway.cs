using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.zNetwork_Example
{
    public class Gateway : Network
    {
        private static readonly Gateway _gateway = new Gateway();

        private Gateway() { }

        public static Gateway GetInstance()
        {
            return _gateway;
        }

        public void ftp(string ip, string targetIp)
        {
            Console.WriteLine($"{ip} makes an ftp to {targetIp}\n");
        }

        public void telnet(string ip, string targetIp)
        {
            Console.WriteLine($"{ip} makes a telnet to {targetIp}\n");
        }
    }
}
