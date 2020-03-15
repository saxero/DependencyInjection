
namespace Services
{
    public class ServicesParameter
    {
        public IFruitProvider provider {set {providerSet(value); } }
        private IFruitProvider _provider;
        public object FruitOfTheDay { get; private set; }
        public double PriceFruitOfTheDay { get; private set; }
        public ServicesParameter()
        {
            
            
        }

        private void providerSet(IFruitProvider provider)
        {
            _provider = provider;
            FruitOfTheDay = _provider.GetFruitOfTheDay();
            PriceFruitOfTheDay = _provider.GetPrice();
        }
        public object GetServiceName()
        {
            return "Generic Name Service";
        }
    }
}