using FactoryAndAbstarctFactoryPattern.AbstractFactory.Regulations.Abstract;
using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingFactories.Abstract
{
    public interface IShippingFactory
    {
        IShippingProfile CreateShippingProfile();
        IRegulation CreateRegulation();
    }
}
