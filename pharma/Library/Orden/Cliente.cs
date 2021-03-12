using System;

namespace Library
{
    public class Cliente
    {
        public Cliente(string clientName, string direccion, IPago pago, IEnvio envio, ISaver destinoDeOrden)
        {
            this.ClientName = clientName;
            this.Direccion = direccion;
            this.Pago = pago;
            this.Envio = envio;
            this.DestinoDeOrden = destinoDeOrden;
        }
        public string Direccion{get;}
        public string ClientName{get;}
        public IPago Pago{get;}
        public IEnvio Envio{get;}
        public ISaver DestinoDeOrden{get;}
    }
}