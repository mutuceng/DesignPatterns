using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingProfiles.Concrete
{
    public class GermanyShippingProfile:IShippingProfile
    {
        public decimal ShippingCost => 8.0m;
        public string Currency => "EUR";
        public string GetShippingDetails() => $"Ülke: Germany, Kargo Ücreti: {ShippingCost} {Currency}";
    }
}
