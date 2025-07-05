using FactoryAndAbstarctFactoryPattern.AbstractFactory.Regulations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.Regulations.Concrete
{
    public class JapanRegulation:IRegulation
    {
        public string ApplyRegulation() => "Ek regülasyon yok.";
    }
}
