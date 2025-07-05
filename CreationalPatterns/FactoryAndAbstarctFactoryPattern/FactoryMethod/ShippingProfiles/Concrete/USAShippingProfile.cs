using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Concrete
{

    public class USAShippingProfile : IShippingProfile
    {
        public decimal ShippingCost => 10.0m;
        public string Currency => "USD";
        public string Regulation => "VAT etiketi zorunlu.";

        public string GetShippingDetails()
        {
            return $"Ülke: USA, Kargo Ücreti: {ShippingCost} {Currency}, Regülasyon: {Regulation}";
        }
    }
}
