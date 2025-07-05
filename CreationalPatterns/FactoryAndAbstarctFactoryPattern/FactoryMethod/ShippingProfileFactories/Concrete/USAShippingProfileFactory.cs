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
    public class USAShippingProfileFactory:IShippingProfileFactory
    {
        public IShippingProfile CreateShippingProfile()
        {
            return new USAShippingProfile();
        }
    }
}
