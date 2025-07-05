using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfileFactories.Abstract;
using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Abstract;
using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfileFactories.Concrete
{
    public class GermanyShippingProfileFactory:IShippingProfileFactory
    {
        private readonly decimal _regulationCost;
        private readonly int _yearlySales;

        public GermanyShippingProfileFactory(decimal regulationCost, int yearlySales)
        {
            _regulationCost = regulationCost;
            _yearlySales = yearlySales;
        }

        public IShippingProfile CreateShippingProfile()
        {
            return new GermanyShippingProfile(_regulationCost, _yearlySales);
        }
    }
}
