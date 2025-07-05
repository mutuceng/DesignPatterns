using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Concrete
{
    public class JapanShippingProfile : IShippingProfile
    {
        public decimal ShippingCost => 1000.0m;
        public string Currency => "JPY";
        public string Regulation => "Ek regülasyon yok.";

        public string GetShippingDetails()
        {
            return $"Ülke: Japan, Kargo Ücreti: {ShippingCost} {Currency}, Regülasyon: {Regulation}";
        }
    }
}
