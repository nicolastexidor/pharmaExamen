namespace Library
{
    //Esta interfaz permite la implementacion del patron Observer, donde en este caso depende de un IEnvio ya que este actua a su vez como IObserver
    //Aplico este patron para asi poder avisar a los envios de generar una orden de envio desde la clase Orden
    public interface IObservable
    {
        void Subscribe(IEnvio observer);

        void Unsubscribe(IEnvio observer);
    }
}