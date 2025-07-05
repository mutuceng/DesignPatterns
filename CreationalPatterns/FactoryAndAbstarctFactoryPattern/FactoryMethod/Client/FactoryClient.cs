using FactoryAndAbstarctFactoryPattern.FactoryMethod.ShippingProfileFactories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstarctFactoryPattern.FactoryMethod.Client
{
    public class FactoryClient
    {
        private readonly IShippingProfileFactory _factory;

        public FactoryClient(IShippingProfileFactory factory)
        {
            _factory = factory;
        }

        public void DisplayShippingDetails()
        {
            var profile = _factory.CreateShippingProfile();
            Console.WriteLine(profile.GetShippingDetails());
        }
    }
}
