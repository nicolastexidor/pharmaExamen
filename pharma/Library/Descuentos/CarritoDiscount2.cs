using System;

namespace Library
{
    public class CarritoDiscount2 : ICarritoDiscount
    {
        

        public double AplicarDescuento(Carrito carrito, IEnvio envio)
        {
            return carrito.TotalCompraAntesDeDescuento() - envio.CostoTotal(carrito.PesoTotal());
        }

        public bool CheckDiscount(Carrito carrito, IEnvio envio)
        {
            foreach (Item item in carrito.Items)
            {   
                if (item.Categoria != new Vitales())
                {
                    return false;
                }
            }
            return true;
            
        }
    }
}