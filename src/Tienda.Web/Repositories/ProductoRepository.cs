using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Data;
using Tienda.Web.Interfaces;
using Tienda.Web.Models;

namespace Tienda.Web.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly TiendaDbContext _tiendaDbContext;

        public ProductoRepository(TiendaDbContext tiendaDbContext)
        {
            _tiendaDbContext = tiendaDbContext;
        }

        public IEnumerable<Producto> Productos => _tiendaDbContext.Productos.Include(c => c.Categoria);

        public IEnumerable<Producto> PreferenciaProductos => _tiendaDbContext.Productos.Where(p => p.Preferidos).Include(c => c.Categoria);

        public Producto GetProductoById(int Id) => _tiendaDbContext.Productos.FirstOrDefault(p => p.Id == Id);
    }
}
