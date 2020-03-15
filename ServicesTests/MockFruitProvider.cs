using Services;

namespace Mocks
{
    public class MockApplesFruitProvider : IFruitProvider
    {
        public string GetFruitOfTheDay()
        {
            return "apples";
        }

        public double GetPrice()
        {
            return 0.89;
        }
    }

    public class MockBananaFruitProvider : IFruitProvider
    {
        public string GetFruitOfTheDay()
        {
            return "bananas";
        }

        public double GetPrice()
        {
            return 1.13;
        }
    }
}