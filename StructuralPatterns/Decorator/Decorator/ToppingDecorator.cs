using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class ToppingDecorator:IPizza
    {
        protected IPizza _pizza;
        public ToppingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }
        public virtual double GetCost()
        {
            return _pizza.GetCost();
        }
    }
}
