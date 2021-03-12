using System;

namespace Library
{
    public class Desodorante: IProducto
    {
       
        public Desodorante()
        {
            this.ProductID = 2;
            this.Name= "Desodorante";
            this.Categoria = new HigienePersonal();
            this.Marca = "AXE";
            this.Description = "Desodorante que evita sudor 24hs";
            this.Precio = 100;
            this.Peso = 0.5;
            this.ImagePath = "...";

        }

    }
}