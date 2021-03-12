using System;

namespace Library
{
    //Esta clase abstracta permite el cumplimiento de OCP, para asi poder crear nuevos productos sin cambiar el codigo antes escrito
    //Tambien permite reutilizar codigo en las implementaciones.
    public abstract class IProducto
    {
        public int ProductID{get;set;}
        public string Name{get;set;}
        public ICategoria Categoria{get;set;}
        public string Marca{get;set;}
        public string Description{get;set;}
        public int Precio{get;set;}
        public double Peso{get;set;}
        public string ImagePath{get;set;}

        public string Info()
        {
            return $"Nombre: {this.Name}\n ID: {this.ProductID}\n Categoria: {this.Categoria.Name}\n Marca: {this.Marca}\n Descripcion: {this.Description}\n Precio: {this.Preciototal()}\n Peso: {this.Peso}";
        }
        
        public int Preciototal()
        {
            int cant = (this.Categoria.Discount * this.Precio) / 100;
            return this.Precio - cant;
        }
        

    }
}