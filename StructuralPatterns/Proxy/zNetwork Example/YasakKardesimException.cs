using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.zNetwork_Example
{
    public class YasakKardesimException:Exception
    {
        public YasakKardesimException(string message)
            : base(message)
        {
        }
    }
}
