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
    public class USAShippingFactory:IShippingFactory
    {
        public IShippingProfile CreateShippingProfile() => new USAShippingProfile();
        public IRegulation CreateRegulation() => new USARegulation();
    }
}
