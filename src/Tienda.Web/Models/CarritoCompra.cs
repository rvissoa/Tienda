using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Data;

namespace Tienda.Web.Models
{
    public class CarritoCompra
    {
        private readonly TiendaDbContext _tiendaDbContext;

        private CarritoCompra(TiendaDbContext tiendaDbContext)
        {
            _tiendaDbContext = tiendaDbContext;
        }

        public string CarritoCompraId { get; set; }

        public List<ItemCarritoCompra> ItemsCarritoCompra { get; set; }

        public static CarritoCompra GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<TiendaDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new CarritoCompra(context) { CarritoCompraId = cartId };
        }

        public void AddToCart(Producto producto, int amount)
        {
            var itemCarritoCompra =
                    _tiendaDbContext.ItemsCarritoCompra.SingleOrDefault(
                        s => s.Producto.Id == producto.Id && s.CarritoCompraId == CarritoCompraId);

            if (itemCarritoCompra == null)
            {
                itemCarritoCompra = new ItemCarritoCompra
                {
                    CarritoCompraId = CarritoCompraId,
                    Producto = producto,
                    Cantidad = 1
                };

                _tiendaDbContext.ItemsCarritoCompra.Add(itemCarritoCompra);
            }
            else
            {
                itemCarritoCompra.Cantidad++;
            }
            _tiendaDbContext.SaveChanges();
        }

        public int RemoveFromCart(Producto producto)
        {
            var itemCarritoCompra =
                    _tiendaDbContext.ItemsCarritoCompra.SingleOrDefault(
                        s => s.Producto.Id == producto.Id && s.CarritoCompraId == CarritoCompraId);

            var localAmount = 0;

            if (itemCarritoCompra != null)
            {
                if (itemCarritoCompra.Cantidad > 1)
                {
                    itemCarritoCompra.Cantidad--;
                    localAmount = itemCarritoCompra.Cantidad;
                }
                else
                {
                    _tiendaDbContext.ItemsCarritoCompra.Remove(itemCarritoCompra);
                }
            }

            _tiendaDbContext.SaveChanges();

            return localAmount;
        }

        public List<ItemCarritoCompra> GetShoppingCartItems()
        {
            return ItemsCarritoCompra ??
                   (ItemsCarritoCompra =
                       _tiendaDbContext.ItemsCarritoCompra.Where(c => c.CarritoCompraId == CarritoCompraId)
                           .Include(s => s.Producto)
                           .ToList());
        }

        public void ClearCart()
        {
            var ItemsCarrito = _tiendaDbContext
                .ItemsCarritoCompra
                .Where(cart => cart.CarritoCompraId == CarritoCompraId);

            _tiendaDbContext.ItemsCarritoCompra.RemoveRange(ItemsCarrito);

            _tiendaDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _tiendaDbContext.ItemsCarritoCompra.Where(c => c.CarritoCompraId == CarritoCompraId)
                .Select(c => c.Producto.Precio * c.Cantidad).Sum();
            return total;
        }
    }
}
