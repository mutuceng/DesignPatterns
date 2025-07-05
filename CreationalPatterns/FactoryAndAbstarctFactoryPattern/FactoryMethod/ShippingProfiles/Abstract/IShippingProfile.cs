using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Abstract
{
    public interface IShippingProfile
    {
        decimal ShippingCost { get; }
        string Currency { get; }
        string Regulation { get; }
        string GetShippingDetails();
    }
}
