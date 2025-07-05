using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfiles.Concrete
{
    public class GermanyShippingProfile : IShippingProfile
    {
        private readonly decimal _regulationCost;
        private readonly int _yearlySales;
        private readonly decimal _unitRegulationCost; // Birim başına regülasyon maliyeti

        public GermanyShippingProfile(decimal regulationCost, int yearlySales)
        {
            _regulationCost = regulationCost;
            _yearlySales = yearlySales;

            _unitRegulationCost = yearlySales > 0 ? regulationCost / yearlySales : 0.0m;
        }

        public decimal ShippingCost => 8.0m + _unitRegulationCost;
        public string Currency => "EUR";
        public string Regulation =>
            $"Birim başına regülasyon maliyeti: {_unitRegulationCost:F2} EUR.";

        public string GetShippingDetails()
        {
            return $"Ülke: Germany, Kargo Ücreti + Regülasyon: {ShippingCost} {Currency}, Regülasyon: {Regulation}";
        }
    }
}
