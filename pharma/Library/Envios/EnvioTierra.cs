using System;

namespace Library
{
    public class EnvioTierra: IEnvio
    {
        public EnvioTierra()
        {
            this.EnvioID = 2;
            this.CostoFijo = 300;
            this.CostoPorKilo = 120;
        }
        public int EnvioID{get;}
        public int CostoFijo{get;}
        public int CostoPorKilo{get;}
        
        public double CostoTotal(double PesoTotal)
        {
            return this.CostoFijo + (this.CostoPorKilo * PesoTotal);
        }

        public void Update(Orden value)
        {
            value.Client.DestinoDeOrden.Exportar(value);
        }

    }
}