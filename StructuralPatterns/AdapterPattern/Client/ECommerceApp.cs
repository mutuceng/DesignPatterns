using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterPattern.Client
{
    public class ECommerceApp
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public ECommerceApp(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void checkout(double amount, string currency)
        {
            // Ödeme işlemini başlat
            bool success = _paymentProcessor.processPayment(amount, currency);
            if (success)
            {
                Console.WriteLine("ECommerceApp: Payment processed successfully!");
                // Ödeme durumunu kontrol et
                string paymentId = "PAYPAL_" + 2213; // Örnek ID
                string status = _paymentProcessor.getPaymentStatus(paymentId);
                Console.WriteLine("ECommerceApp: Payment status: " + status);
            }
            else
            {
                Console.WriteLine("ECommerceApp: Payment failed!");
            }
        }
    }
}
