using FactoryAndAbstarctFactoryPattern.AbstractFactory.Regulations.Abstract;
using FactoryAndAbstarctFactoryPattern.AbstractFactory.Regulations.Concrete;
using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingFactories.Abstract;
using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Abstract;
using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingFactories.Concrete
{
    public class GermanyShippingFactory:IShippingFactory
    {
        private readonly decimal _regulationCost;
        private readonly int _yearlySales;
        public GermanyShippingFactory(decimal regulationCost, int yearlySales)
        {
            _regulationCost = regulationCost;
            _yearlySales = yearlySales;
        }
        public IShippingProfile CreateShippingProfile() => new GermanyShippingProfile();
        public IRegulation CreateRegulation() => new GermanyRegulation(_regulationCost / _yearlySales);
    }
}
