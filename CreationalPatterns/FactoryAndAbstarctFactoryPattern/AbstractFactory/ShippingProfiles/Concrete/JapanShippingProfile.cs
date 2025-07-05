using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Concrete
{
    public class JapanShippingProfile:IShippingProfile
    {
        public decimal ShippingCost => 1000.0m;
        public string Currency => "JPY";
        public string GetShippingDetails() => $"Ülke: Japan, Kargo Ücreti: {ShippingCost} {Currency}";
    }
}
