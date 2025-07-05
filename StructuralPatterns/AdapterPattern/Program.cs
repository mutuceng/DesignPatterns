using AdapterPattern.Adaptee;
using AdapterPattern.Adapter;
using AdapterPattern.Client;
using AdapterPattern.Target;

MedyaPlayer medyaPlayer = new MedyaPlayer();
medyaPlayer.Oynat("mp3", "song.mp3");


medyaPlayer.Oynat("mp4", "video.mp4");
medyaPlayer.Oynat("vlc", "movie.vlc");

Console.WriteLine("\n--- Ödeme İşlemleri ---\n");
PaypalAPI payPalAPI = new PaypalAPI();
StripeAPI stripeAPI = new StripeAPI();

IPaymentProcessor stripeProcessor = new StripeAdapter(stripeAPI, 2);

ECommerceApp stripeApp = new ECommerceApp(stripeProcessor);
stripeApp.checkout(200.0, "EUR");


IPaymentProcessor payPalProcessor = new PayPalAdapter(payPalAPI, "user12", "merchant231");
ECommerceApp app = new ECommerceApp(payPalProcessor);
app.checkout(100.0, "USD");
