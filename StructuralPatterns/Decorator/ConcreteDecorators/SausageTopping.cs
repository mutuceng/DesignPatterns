using Decorator.Decorator;
using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorators
{
    public class SausageTopping:ToppingDecorator
    {
        public SausageTopping(IPizza pizza) : base(pizza) { }
        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Sausage Topping";
        }
        public override double GetCost()
        {
            return _pizza.GetCost() + 2.50; // Sosis ekleme maliyeti
        }
    }
}
