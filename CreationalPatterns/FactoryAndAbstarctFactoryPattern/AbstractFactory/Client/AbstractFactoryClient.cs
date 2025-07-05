using FactoryAndAbstarctFactoryPattern.AbstractFactory.ShippingFactories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.AbstractFactory.Client
{
    public class AbstractFactoryClient
    {
        private readonly IShippingFactory _factory;
        public AbstractFactoryClient(IShippingFactory factory) => _factory = factory;
        public void DisplayShippingDetails()
        {
            var profile = _factory.CreateShippingProfile();
            var regulation = _factory.CreateRegulation();
            Console.WriteLine($"{profile.GetShippingDetails()}, Regülasyon Uygulaması: {regulation.ApplyRegulation()}");
        }
    }
}
