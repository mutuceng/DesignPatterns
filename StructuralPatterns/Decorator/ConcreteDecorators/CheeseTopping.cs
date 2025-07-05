using Decorator.Decorator;
using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorators
{
    public class CheeseTopping:ToppingDecorator
    {
        public CheeseTopping(IPizza pizza) : base(pizza) { }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 2.00; // Peynir ekleme maliyeti
        }
    }
}
