using StrategyPattern.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Context
{
    public class NavigatorContext
    {
        protected RouteStrategy _routeStrategy;

        public NavigatorContext(RouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void ExecuteStrategy(string start, string end)
        {
            _routeStrategy.BuildRoute(start, end);
        }
    }
}
