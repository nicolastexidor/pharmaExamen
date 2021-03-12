using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Esta interfaz permite el cumplimiento de OCP, permitiendo crear nuevos criterios de busqueda sin modificar el codigo escrito anteriormente
    /// </summary>
    public interface ISearcher
    {
        List<IProducto> Criterio(List<IProducto> productos, int id, string name, int categoriaId, string categoriaName);
    }
}