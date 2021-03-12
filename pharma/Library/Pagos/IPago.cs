using System;

namespace Library
{
    /// <summary>
    /// Esta interfaz permite el cumplimiento de OCP, permitiendo crear nuevas formas de pago sin modificar el codigo escrito anteriormente
    /// </summary>
    public interface IPago
    {
       int Monto{get;}
       string PagoInfo();
    }
}