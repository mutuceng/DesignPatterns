using Proxy.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.RealObject
{
    public class GercekBasbakan : Basbakan
    {
        public void dertDinle(string dert)
        {
            var ilkKelime = dert?.Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? "";
            Console.WriteLine("Basbakan: Dinliyorum. " + ilkKelime + "\n");
        }

        public void isBul(string yakinim)
        {
            Console.WriteLine("Basbakan: Bana boyle isteklerle gelmeyin.\n");
        }
    }
}
