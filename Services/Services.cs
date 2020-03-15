using System;

namespace Services
{
    public class ServicesConstructor
    {
        public object FruitOfTheDay { get; private set; }
        public double PriceFruitOfTheDay { get; private set; }
              
        public ServicesConstructor(IFruitProvider provider)
        {
            FruitOfTheDay = provider.GetFruitOfTheDay();
            PriceFruitOfTheDay = provider.GetPrice();
        }

        public object GetServiceName()
        {
            return "Generic Name Service";
        }
    }
}
