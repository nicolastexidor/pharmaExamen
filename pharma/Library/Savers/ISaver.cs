using System;

namespace Library
{
    /// <summary>
    /// Esta interfaz permite el cumplimiento de OCP, permitiendo crear nuevos exportadores de informacion sin modificar el codigo escrito anteriormente
    /// </summary>
    public interface ISaver
    {
        void Exportar(Orden orden);
    }
}