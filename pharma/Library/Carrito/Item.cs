using System;
using System.Collections.Generic;

namespace Library
{
    //Esta clase cumple con Expert debido a que todos sus metodos se utilizan con la informacion dada por la clase misma
    //
    //Esta clase tambien cumple con el principio de inversion de dependencias al estar compuesta por IitemDiscount, de esta forma permitiendo agregar nuevos descuentos
    //sin la necesidad de depender de una clase nueva de descuento
    //
    //Tambien se aplica el principio de inversion de dependencias al depender de IProducto en lugar de depender de cada producto individual, para asi poder agregar nuevos productos
    //sin tener que modificar esta clase
    public class Item
    {
        private List<IitemDiscount> Discounts = new List<IitemDiscount>();

        public Item(IProducto producto, int cantidad)
        {
            this.Producto =  producto;
            this.Cantidad =  cantidad;
            this.Name = producto.Name;
            this.ItemId = producto.ProductID;
            this.CostoUnitario = producto.Preciototal();
            this.Categoria = producto.Categoria;
            this.Marca = producto.Marca;
        }
        public IProducto Producto{get;}
        public int Cantidad{get;}
        public string Name{get;}
        public int ItemId {get;}
        public int CostoUnitario{get;}
        public ICategoria Categoria{get;}
        public string Marca{get;}
        private int SubTotalAntesDeDescuento()
        {
            return this.Producto.Preciototal() * this.Cantidad;
        }
        public int SubTotal()
        {
            Discounts.Add(new ItemDiscount1());
            Discounts.Add(new ItemDiscount2());
            Discounts.Add(new ItemDiscount3());

            foreach(IitemDiscount discount in Discounts)
            {
                if(discount.ChekDiscount(this, SubTotalAntesDeDescuento()))
                {
                    return discount.AplicarDescuento(this, SubTotalAntesDeDescuento());
                }
            }
            return SubTotalAntesDeDescuento();
        }
        public string Detalles()
        {
            return $"{this.Producto.Name}, {this.Producto.ProductID}, {this.Producto.Preciototal()}, {this.Cantidad}";
        }
    }
}