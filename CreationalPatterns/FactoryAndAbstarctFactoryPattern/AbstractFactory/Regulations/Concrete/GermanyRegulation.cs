using FactoryAndAbstarctFactoryPattern.AbstractFactory.Regulations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.Regulations.Concrete
{
    public class GermanyRegulation:IRegulation
    {
        private readonly decimal _unitRegulationCost;
        public GermanyRegulation(decimal unitRegulationCost) => _unitRegulationCost = unitRegulationCost;
        public string ApplyRegulation() => $"Birim başına {_unitRegulationCost:F2} EUR regülasyon uygulandı.";
    }
}
