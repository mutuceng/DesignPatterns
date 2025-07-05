using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using System;

namespace AdapterPattern.Adapter
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PaypalAPI _paypalAPI;
        private readonly string _userToken;
        private readonly string _merchantId;

        public PayPalAdapter(PaypalAPI paypalAPI, string userToken, string merchantId)
        {
            _paypalAPI = paypalAPI;
            _userToken = userToken;
            _merchantId = merchantId;
        }

        public string getPaymentStatus(string paymentId)
        {
            return _paypalAPI.CheckTransactionStatus(paymentId);
        }

        public bool processPayment(double amount, string currency)
        {
            // double -> decimal dönüşümü
            string paymentId = _paypalAPI.CreateTransaction(
                (decimal)amount, currency, _userToken, _merchantId
            );
            // Ödeme ID'si alındıysa ödeme başarılı sayılır
            return !string.IsNullOrEmpty(paymentId);
        }
    }
}
