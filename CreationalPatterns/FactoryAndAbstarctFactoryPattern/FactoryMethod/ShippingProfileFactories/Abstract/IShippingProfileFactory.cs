using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfileFactories.Abstract
{
    public interface IShippingProfileFactory
    {
        IShippingProfile CreateShippingProfile();
    }
}
