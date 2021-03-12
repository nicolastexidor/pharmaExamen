using System;

namespace Library
{
    //Esta interfaz permite el cumplimiento de OCP, permitiendo agregar nuevos descuentos sin modificar el codigo antes presentado
    //Por otro lado creo que incumple SRP al tener dos razones de cambio, una solucion a esto seria aplicar ISP, en mi caso no lo hice ya que crei
    //que complicaria más las cosas al tener que agregar una nueva lista en Carrito.
    public interface ICarritoDiscount
    {
        bool CheckDiscount(Carrito carrito, IEnvio envio);

        double AplicarDescuento(Carrito carrito, IEnvio envio);
    }
}