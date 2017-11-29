using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Models;
using Tienda.Web.Models.CarritoCompraViewModels;

namespace Tienda.Web.Components
{
    public class ResumenCompra : ViewComponent
    {
        private readonly CarritoCompra _carritoCompra;
        public ResumenCompra(CarritoCompra carritoCompra)
        {
            _carritoCompra = carritoCompra;
        }

        public IViewComponentResult Invoke()
        {
            var items = _carritoCompra.GetShoppingCartItems();
            _carritoCompra.ItemsCarritoCompra = items;

            var carritoCompraViewModel = new CarritoCompraViewModel
            {
                CarritoCompra = _carritoCompra,
                CarritoCompraTotal = _carritoCompra.GetShoppingCartTotal()
            };
            return View(carritoCompraViewModel);
        }
    }
}
