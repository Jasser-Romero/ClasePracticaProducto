using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IProductoService:IService<Producto>
    {
        Producto GetProductoById(int code);
        Producto GetProductosByUnidadMedida(UnidadMedida um);
        Producto GetProductosByFechaVencimiento(DateTime dt);
        Producto GetProductosByRangoPrecio(decimal start, decimal end);
        string GetProductosAsJson();
        Producto[] GetProductosOrderByPrecio();
        int GetLastProductoId();
    }
}
