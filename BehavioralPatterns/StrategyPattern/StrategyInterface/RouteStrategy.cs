using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyInterface
{
    public interface RouteStrategy
    {
        public void BuildRoute(string start, string end);
    }
}
