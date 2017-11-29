using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Data;
using Tienda.Web.Interfaces;
using Tienda.Web.Models;

namespace Tienda.Web.Repositories
{
    public class OrdenRepository : IOrdenRepository
    {
        private readonly TiendaDbContext _tiendaDbContext;
        private readonly CarritoCompra _carritoCompra;


        public OrdenRepository(TiendaDbContext tiendaDbContext, CarritoCompra carritoCompra)
        {
            _tiendaDbContext = tiendaDbContext;
            _carritoCompra = carritoCompra;
        }


        public void CrearOrden(Orden orden)
        {
            orden.OrdenColocada = DateTime.Now;

            _tiendaDbContext.Ordenes.Add(orden);

            var itemsCarritoCompra = _carritoCompra.ItemsCarritoCompra;

            foreach (var itemCarritoCompra in itemsCarritoCompra)
            {
                var detalleOrden = new DetalleOrden()
                {
                    Cantidad = itemCarritoCompra.Cantidad,
                    ProductoId = itemCarritoCompra.Producto.Id,
                    OrdenId = orden.Id,
                    Precio = itemCarritoCompra.Producto.Precio
                };

                _tiendaDbContext.DetalleOrdenes.Add(detalleOrden);
            }

            _tiendaDbContext.SaveChanges();
        }
    }
}
