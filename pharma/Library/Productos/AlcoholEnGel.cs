using System;

namespace Library
{
    public class AlcoholEnGel: IProducto
    {
        public AlcoholEnGel()
        {
            this.ProductID = 1;
            this.Name= "Alcohol en gel";
            this.Categoria = new Vitales();
            this.Marca = "Marca";
            this.Description = "Sirve para desinfectar la zona en la que se aplique";
            this.Precio = 200;
            this.Peso = 0.5;
            this.ImagePath = "...";

        }


    }
}