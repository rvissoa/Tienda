using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Web.Interfaces;
using Tienda.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace Tienda.Web.Controllers
{
    public class OrdenController : Controller
    {
        private readonly IOrdenRepository _ordenRepository;
        private readonly CarritoCompra _carritoCompra;

        public OrdenController(IOrdenRepository ordenRepository, CarritoCompra carritoCompra)
        {
            _ordenRepository = ordenRepository;
            _carritoCompra = carritoCompra;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Orden orden)
        {
            var items = _carritoCompra.GetShoppingCartItems();
            _carritoCompra.ItemsCarritoCompra = items;
            if (_carritoCompra.ItemsCarritoCompra.Count == 0)
            {
                ModelState.AddModelError("", "Su carrito está vacío, agregue algunas productos primero");
            }

            if (ModelState.IsValid)
            {
                _ordenRepository.CrearOrden(orden);
                _carritoCompra.ClearCart();
                return RedirectToAction("Revisión completada");
            }

            return View(orden);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Gracias por tu orden";
            return View();
        }
    }
}