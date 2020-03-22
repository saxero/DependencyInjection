using System;

namespace Services
{
    public interface IProduct
    {
       void setPrecioVenta(double precio);
       double Precio {get;set;}
    }
    public class Storage
    {
        public Storage(IProduct Product)
        {
            Product.setPrecioVenta(Product.Precio * 3);
        }
    }
}