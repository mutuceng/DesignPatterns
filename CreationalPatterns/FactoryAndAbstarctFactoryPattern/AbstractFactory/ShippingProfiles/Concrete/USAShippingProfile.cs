using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Concrete
{
    public class USAShippingProfile:IShippingProfile
    {
        public decimal ShippingCost => 10.0m;
        public string Currency => "USD";
        public string GetShippingDetails() => $"Ülke: USA, Kargo Ücreti: {ShippingCost} {Currency}";
    }
}
