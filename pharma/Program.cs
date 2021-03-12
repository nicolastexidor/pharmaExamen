using System;
using Library;
namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si tira error de que no encuentra el file, como me paso a mi, coloque el texto en Documentos y ponga el path necesario
            string ProductosAImportar = "C:\\Users\\NICO\\Documents\\Productos.txt";
            Catalogo catalogo1 = new Catalogo();
            IReader leerArchivo = new TextReader();
 
            leerArchivo.ImportProducts(catalogo1, ProductosAImportar);
        }
    }
}
