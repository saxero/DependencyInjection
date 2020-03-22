using Moq;
using NUnit.Framework;
using Services;

namespace ServicesTests
{
    [TestFixture]
    public class StorageTests
    {
        [Test]
        public void Storage_WhenCreated_SetThePrecioVenta()
        {
            var producto = new Mock<IProduct>();
            //producto.SetupGet(p=> p.Precio).Returns(20.2);
            producto.Setup(p=> p.Precio).Returns(20.2);
            var precioFinal = producto.Object.Precio * 3;
            
            var storage = new Storage(producto.Object);

            producto.Verify(s=> s.setPrecioVenta(precioFinal));

        }
    }
}