using System;
using System.Collections.Generic;

namespace Library
{
    public class Catalogo
    {
        private List<IProducto> Productos = new List<IProducto>(); 

        public int CantidadDeProducto(IProducto producto)
        {
            int cant = 0;
            foreach (IProducto prod in Productos)
            {
                if (prod.ProductID == producto.ProductID)
                {
                    cant += 1;
                }
            }
            return cant;
        }
        public void AddProduct(IProducto producto)
        {
            this.Productos.Add(producto);
        }
        public void RemoveProduct(IProducto producto)
        {
            foreach (IProducto prod in Productos)
            {
                if(prod.ProductID == producto.ProductID)
                {
                    this.Productos.Remove(producto);
                    break;
                }
            }
        }
        //Soy consciente de que esta no es la mejor forma de implementar el buscador debido a que si quiero agregar un nuevo criterio debo agregar el parametro correspondiente
        public List<IProducto> SearchProduct(ISearcher searcher, int id, string name, int categoriaId, string categoriaName)
        {
            return searcher.Criterio(Productos, id,name,categoriaId,categoriaName);
        }
    }
}