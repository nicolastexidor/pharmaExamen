using System;
using System.Text;
using System.IO;

namespace Library
{
    public class TextReader: IReader
    {
        public TextReader(){}

        public void ImportProducts(Catalogo catalogo, string archivo)
        {
            string[] producto = File.ReadAllLines(archivo);

            foreach (string line in producto)
            {  
                //Se que esto viola el patron de polimorfismo, pero por falta de tiempo no me puedo permitir crear el sistema de Chain of Responsability necesario para manejar este problema
                //Dejandolo de esta forma, si quiero agregar un producto distinto debo crear otro caso de elseif
                if (line.Contains("AlcoholEnGel"))
                {
                    catalogo.AddProduct(new AlcoholEnGel());
                }
                else if (line.Contains("Desodorante"))
                {
                    catalogo.AddProduct(new Desodorante());
                }
            }
        }
    }
}