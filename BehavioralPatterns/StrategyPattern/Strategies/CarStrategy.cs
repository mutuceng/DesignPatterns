using StrategyPattern.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
    public class CarStrategy : RouteStrategy
    {
        public void BuildRoute(string start, string end)
        {
            Console.WriteLine("Driving from " + start + " to " + end);
        }
    }
}
