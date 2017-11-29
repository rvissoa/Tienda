using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Models;

namespace Tienda.Web.Data
{
    public class TiendaDbContext : IdentityDbContext<IdentityUser>
    {
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<ItemCarritoCompra> ItemsCarritoCompra { get; set; }

        public DbSet<Orden> Ordenes { get; set; }

        public DbSet<DetalleOrden> DetalleOrdenes { get; set; }

        public DbSet<CarritoCompra> CarritoCompra { get; set; }
    }
}
