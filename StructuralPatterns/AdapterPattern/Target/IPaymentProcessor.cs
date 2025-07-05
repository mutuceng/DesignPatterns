using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterPattern.Target
{
    public interface IPaymentProcessor
    {
        bool processPayment(double amount, string currency);

        string getPaymentStatus(string paymentId);
    }
}
