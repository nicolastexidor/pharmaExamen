using System;
using System.Collections.Generic;

namespace Library
{
    public class CateIdSearcher: ISearcher
    {
        public List<IProducto> Criterio(List<IProducto> productos, int id, string name, int categoriaId, string categoriaName)
        {
            List<IProducto> productos1 = new List<IProducto>();
            foreach (IProducto prod in productos)
            {
                if (prod.Categoria.CategoryID == categoriaId)
                {
                    productos1.Add(prod);
                }
            }
            return productos1;
        }
    }
}