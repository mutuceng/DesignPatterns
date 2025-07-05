using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class StripeAdapter : IPaymentProcessor
    {
        private readonly StripeAPI _stripeAPI;
        private readonly int _apiVersion;

        public StripeAdapter(StripeAPI stripeAPI, int apiVersion)
        {
            _apiVersion = apiVersion;
            _stripeAPI = stripeAPI;
        }
        public string getPaymentStatus(string paymentId)
        {
            return _stripeAPI.GetChargeStatus(paymentId);
        }

        public bool processPayment(double amount, string currency)
        {
            string chargeId = _stripeAPI.CreateCharge(amount, currency, _apiVersion);
            return !string.IsNullOrEmpty(chargeId);
        }
    }
}
