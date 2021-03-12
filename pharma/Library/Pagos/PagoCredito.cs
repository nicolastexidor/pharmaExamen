using System;

namespace Library
{
    public class PagoCredito : IPago
    {
        public PagoCredito(int numTarjeta, DateTime expiracion, string bankName, int monto)
        {
            this.NumTarjeta = numTarjeta;
            this.Expiracion = expiracion;
            this.BankName = bankName;
            this.Monto = monto;
        }
        public int NumTarjeta {get;}
        public DateTime Expiracion{get;}
        public string BankName{get;}
        public int Monto{get;}

        public string PagoInfo()
        {
            return $"Pago por Credito de {this.Monto}, Num de tarjeta: {this.NumTarjeta}, Expiración: {this.Expiracion}, Nombre del banco: {this.BankName}";
        }
    }
}