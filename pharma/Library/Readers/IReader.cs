using System;
using System.Text;
using System.IO;

namespace Library
{
    /// <summary>
    /// Esta interfaz permite el cumplimiento de OCP, permitiendo crear nuevos lectores de archivos sin modificar el codigo escrito anteriormente
    /// </summary>
    public interface IReader
    {
        void ImportProducts(Catalogo catalogo, string archivo);
    }
}