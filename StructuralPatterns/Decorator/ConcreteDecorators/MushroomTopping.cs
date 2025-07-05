using Decorator.Decorator;
using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorators
{
    public class MushroomTopping : ToppingDecorator
    {
        public MushroomTopping(IPizza pizza) : base(pizza) { }
        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", Mushroom Topping";
        }
        public override double GetCost()
        {
            return _pizza.GetCost() + 1.75; // Mantar ekleme maliyeti
        }
    }
}
