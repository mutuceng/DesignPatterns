using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
    public class StripeAPI
    {
        public string CreateCharge(double amount, string currency, int apiVersion)
        {
            Console.WriteLine($"Stripe: {amount} {currency} tutarında ödeme oluşturuluyor (API Version: {apiVersion})");
            return $"STRIPE_{DateTime.Now.Ticks}";
        }

        public string GetChargeStatus(string chargeId)
        {
            Console.WriteLine($"Stripe: {chargeId} ID'li ödemenin durumu kontrol ediliyor.");
            // Örnek olarak her zaman başarılı döndürüyoruz
            return "Success";
        }

    }
}
