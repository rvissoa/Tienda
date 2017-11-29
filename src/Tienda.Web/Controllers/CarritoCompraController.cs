using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Web.Interfaces;
using Tienda.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Tienda.Web.Models.CarritoCompraViewModels;

namespace Tienda.Web.Controllers
{
    public class CarritoCompraController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        private readonly IProductoRepository _productoRepository;
        private readonly CarritoCompra _carritoCompra;

        public CarritoCompraController(IProductoRepository productoRepository, CarritoCompra carritoCompra)
        {
            _productoRepository = productoRepository;
            _carritoCompra = carritoCompra;
        }

        [Authorize]
        public IActionResult Index()
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

        [Authorize]
        public RedirectToActionResult AgregarCarritoCompra(int productoId)
        {
            var selectedProducto = _productoRepository.Productos.FirstOrDefault(p => p.Id == productoId);
            if (selectedProducto != null)
            {
                _carritoCompra.AddToCart(selectedProducto, 1);
            }
            return RedirectToAction("Index");
        }
        /*
        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink = _productoRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _carritoCompra.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction("Index");
        }*/
    }
}