using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Esta clase implementa la interfaz IObserver para poder avisar al envio de generar una orden de envio
    /// </summary>
    public class Orden: IObservable
    {
        private List<IEnvio> enviosObserver = new List<IEnvio>();
        public Orden(Cliente client, List<Item> itemsToOrder)
        {
            this.OrdenID = OrdenID;
            OrdenID++;
            this.Estado = "CREADA";
            this.FechaCreacion = DateTime.Now;
            this.Client = client;
            this.ItemsToOrder = itemsToOrder;
        }
        public List<Item> ItemsToOrder = new List<Item>();
        public int OrdenID{get;private set;}=10001;
        public string Estado{get;set;}
        public DateTime FechaCreacion{get;}
        public Cliente Client{get;}

        public void PlaceOrder()
        {
            foreach (IEnvio envio in enviosObserver)
            {
                envio.Update(this);
            }
        }

        public void Subscribe(IEnvio observer)
        {
            if(! enviosObserver.Contains(observer))
            {
                enviosObserver.Add(observer);
            }
        }

        public void Unsubscribe(IEnvio observer)
        {
            if (enviosObserver.Contains(observer))
            {
                enviosObserver.Remove(observer);
            }
        }
    }
}