using NUnit.Framework;
using Services;
using Mocks;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var service = new ServicesConstructor(new MockApplesFruitProvider());

            var result = service.GetServiceName();
            var fruitOfTheDay = service.FruitOfTheDay;
            Assert.That(result, Is.EqualTo("Generic Name Service"));
            Assert.That(fruitOfTheDay, Is.EqualTo("apples"));
            Assert.That(service.PriceFruitOfTheDay, Is.EqualTo(0.89));
        }

        [Test]
        public void Test_DependencyInjectioViaProperty()
        {
            var service = new ServicesParameter();
            service.provider = new MockApplesFruitProvider();

            var fruitOfTheDay = service.FruitOfTheDay;

            Assert.That(fruitOfTheDay, Is.EqualTo("apples"));
        }
    }
}