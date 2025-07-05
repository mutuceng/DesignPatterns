using Decorator.Decorator;
using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorators
{
    public class OliveTopping:ToppingDecorator
    {
        public OliveTopping(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Olive Topping";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.50; // Zeytin ekleme maliyeti
        }
    }
}
