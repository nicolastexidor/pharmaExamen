using System;

namespace Library
{
    //Esta interfaz permite el cumplimiento de OCP al poder agregar nuevos tipos de envio sin modificar el codigo antes escrito
    //Por otro lado, el metodo Update() es un intento de aplicar el patron Observer el cual soy consciente de que no esta bien implementado por lo explicado en otras clases

    public interface IEnvio
    {
        int EnvioID{get;}
        int CostoFijo{get;}
        int CostoPorKilo{get;}
        double CostoTotal(double PesoTotal);
        void Update(Orden value);
        
    }
}