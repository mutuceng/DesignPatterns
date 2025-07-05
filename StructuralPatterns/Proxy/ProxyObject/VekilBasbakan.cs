using Proxy.CommonInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proxy.ProxyObject
{
    public class VekilBasbakan : Basbakan
    {
        private readonly Basbakan _gercekBasbakan;

        public VekilBasbakan(Basbakan gercekBasbakan)
        {
            _gercekBasbakan = gercekBasbakan;
        }

        public void dertDinle(string dert)
        {
            if (ayikla(dert))
                ilet(dert);
        }

        public void isBul(string yakinim)
        {
            Console.WriteLine("VekilBasbakan: Is bulma talebi alindi, işçi havuzuna eklendi.");
            _gercekBasbakan.isBul(yakinim);
        }

        private bool ayikla(string dert)
        {
            if(dert.Contains("iş"))
            {
                Console.WriteLine("VekilBasbakan: Bu dert iş ile ilgili, dinlenmeye gerek yok.");
                return false;
            }
            return true;
        }

        private void ilet(string dert)
        {
            _gercekBasbakan.dertDinle(dert);
        }

    }
}
