using System;

namespace Library
{
    public class EnvioAire: IEnvio
    {
        public EnvioAire()
        {
            this.EnvioID = 1;
            this.CostoFijo = 1000;
            this.CostoPorKilo = 300;
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
            bool IsValid = true;
            foreach(Item item in value.ItemsToOrder)
            {     
                if (item.Name != null && item.ItemId > 0 && item.Cantidad > 0 && item.SubTotal() > 0)
                {
                    IsValid = true;
                }
                else
                {
                    IsValid = false;
                    break;
                }
            }
            if (IsValid == true)
            {
                value.Client.DestinoDeOrden.Exportar(value);
                value.Estado = "ENVIADA";
            }
            else
            {
                value.Estado = "RECHAZADA";
            }
            
        }
    }
}