using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Web.Interfaces;
using Tienda.Web.Models.HomeViewModel;

namespace Tienda.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            ViewData["Message"] = "Somos una tienda Online super facil y rapida!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        
        private readonly IProductoRepository _productoRepository;

        public HomeController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferenciaProductos = _productoRepository.PreferenciaProductos
            };
            return View(homeViewModel);
        }
    }
}
