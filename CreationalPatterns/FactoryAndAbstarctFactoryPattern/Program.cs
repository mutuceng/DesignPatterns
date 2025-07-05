using FactoryAndAbstarctFactoryPattern.AbstractFactory.Client;
using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingFactories.Concrete;
using FactoryAndAbstarctFactoryPattern.FactoryMethod.Client;
using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfileFactories.Concrete;


// // Kötü yaklaşım 
//public class ShippingProfile
//{
//    public string Country { get; }
//    public decimal ShippingCost { get; }
//    public string Currency { get; }
//    public string Regulation { get; }

//    // USA constructor
//    public ShippingProfile()
//    {
//        Country = "USA";
//        ShippingCost = 10.0m;
//        Currency = "USD";
//        Regulation = "VAT etiketi zorunlu.";
//    }

//    // Germany constructor
//    public ShippingProfile(decimal regulationCost, int yearlySales)
//    {
//        Country = "Germany";
//        decimal unitRegulationCost = yearlySales > 0 ? regulationCost / yearlySales : 0.0m;
//        ShippingCost = 8.0m + unitRegulationCost; // Birim başına regülasyon maliyeti kargo ücretine ekleniyor
//        Currency = "EUR";
//        Regulation = $"Birim başına regülasyon maliyeti: {unitRegulationCost:F2} EUR.";
//    }

//    // Japan constructor
//    public static ShippingProfile ForJapan()
//    {
//        return new ShippingProfile("Japan", 1000.0m, "JPY", "Ek regülasyon yok.");
//    }

//    // Özel constructor
//    private ShippingProfile(string country, decimal cost, string currency, string regulation)
//    {
//        Country = country;
//        ShippingCost = cost;
//        Currency = currency;
//        Regulation = regulation;
//    }

//    public string GetShippingDetails()
//    {
//        return $"Ülke: {Country}, Kargo Ücreti: {ShippingCost} {Currency}, Regülasyon: {Regulation}";
//    }
//}
class Program
{
    static void Main(string[] args)
    {
        // Kötü Yaklaşım.
        //var usaProfile = new ShippingProfile();
        //Console.WriteLine(usaProfile.GetShippingDetails());

        //var germanyProfile = new ShippingProfile(25.0m, 1000);
        //Console.WriteLine(germanyProfile.GetShippingDetails());

        //var japanProfile = ShippingProfile.ForJapan();
        //Console.WriteLine(japanProfile.GetShippingDetails());

        // Factory Method'lu Yaklaşım.
        var usaClient = new FactoryClient(new USAShippingProfileFactory());
        usaClient.DisplayShippingDetails();
        // Çıktı: Ülke: USA, Kargo Ücreti: 10.0 USD, Regülasyon: VAT etiketi zorunlu.

        var germanyClient = new FactoryClient(new GermanyShippingProfileFactory(50.0m, 1000));
        germanyClient.DisplayShippingDetails();
        // Çıktı: Ülke: Germany, Kargo Ücreti: 8.0 EUR + Regülasyon, Birim başına regülasyon maliyeti: 0.05 EUR.

        var japanClient = new FactoryClient(new JapanShippingProfileFactory());
        japanClient.DisplayShippingDetails();
        // Çıktı: Ülke: Japan, Kargo Ücreti: 1000.0 JPY, Regülasyon: Ek regülasyon yok.


        // Abstract Factory'li Yaklaşım.
        var usaClientAbs = new AbstractFactoryClient(new USAShippingFactory());
        usaClient.DisplayShippingDetails();

        var germanyClientAbs = new AbstractFactoryClient(new GermanyShippingFactory(25.0m, 1000));
        germanyClient.DisplayShippingDetails();

        var japanClientAbs = new AbstractFactoryClient(new JapanShippingFactory());
        japanClient.DisplayShippingDetails();
    }
}