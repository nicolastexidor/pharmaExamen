using System;

namespace Library
{
    public class CarritoDiscount1 : ICarritoDiscount
    {

        public double AplicarDescuento(Carrito carrito, IEnvio envio)
        {
            return (carrito.TotalCompraAntesDeDescuento() * 3) / 100;   
        }

        public bool CheckDiscount(Carrito carrito, IEnvio envio)
        {
            if (carrito.TotalCompraAntesDeDescuento() > 12500)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}