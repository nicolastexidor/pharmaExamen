using System;

namespace Library
{
    public class PagoContado: IPago
    {
        public PagoContado(int monto)
        {
            this.Monto = monto;
        }
        public int Monto{get;}

        public string PagoInfo()
        {
            return $"Monto del pago a contado: {Monto}";
        }
    }
}