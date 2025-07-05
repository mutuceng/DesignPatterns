using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
    public class PaypalAPI
    {
        public string CreateTransaction(decimal amount, string currencyCode, string userToken, string merchantId)
        {
            Console.WriteLine($"PayPal: {amount} {currencyCode} tutarında işlem başlatılıyor (Merchant: {merchantId}, Token: {userToken})");
            return $"PAYPAL_{DateTime.Now.Ticks}";
        }

        public string CheckTransactionStatus(string transactionId)
        {
            Console.WriteLine($"PayPal: {transactionId} ID'li işlemin durumu kontrol ediliyor.");
            // Örnek olarak her zaman başarılı döndürüyoruz
            return "Success";
        }

    }
}
