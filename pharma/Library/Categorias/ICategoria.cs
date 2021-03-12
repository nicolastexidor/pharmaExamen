using System;

namespace Library
{
    //Esta interfaz permite el cumplimiento de OCP, de esta forma permitiendo agregar nuevas categorias sin modificar el codigo antes escrito.
    public interface ICategoria
    {
        int CategoryID{get;}
        string Name{get;}
        string Description{get;}
        int Discount{get;}

    }
}