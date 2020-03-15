using NUnit.Framework;
using Services;
using Mocks;
using Moq;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private ServicesParameter service = new ServicesParameter();
        private Mock<IFruitProvider> mockService = new Mock<IFruitProvider>();

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

        [SetUp]
        public void SetUp()
        {
            mockService.Setup(s => s.GetFruitOfTheDay()).Returns("The fruit of the day");
            mockService.Setup(s => s.GetPrice()).Returns(1.15);
            
            service.provider = mockService.Object;
        }

        [Test]
        public void Test_WithMock()
        {
            Assert.That(service.FruitOfTheDay, Is.EqualTo("The fruit of the day"));
            Assert.That(service.PriceFruitOfTheDay, Is.EqualTo(1.15));
        }
    }
}