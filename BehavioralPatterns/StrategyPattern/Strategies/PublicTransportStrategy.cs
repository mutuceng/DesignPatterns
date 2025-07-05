using StrategyPattern.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
    public class PublicTransportStrategy : RouteStrategy
    {
        public void BuildRoute(string start, string end)
        {
           Console.WriteLine("Taking public transport from " + start + " to " + end);
        }
    }
}
