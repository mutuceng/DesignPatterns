using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteProduct
{
    public class BasePizza : IPizza
    {
        public double GetCost()
        {
            return 10.00; // Temel pizza fiyatı
        }

        public string GetDescription()
        {
            return "Basic Pizza";
        }
    }
}
