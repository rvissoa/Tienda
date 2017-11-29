using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Models;

namespace Tienda.Web.Interfaces
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> Productos { get; }
        IEnumerable<Producto> PreferenciaProductos { get; }
        Producto GetProductoById(int Id);
    }
}
