using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Web.Interfaces;
using Tienda.Web.Models.ProductoViewModels;
using Tienda.Web.Models;

namespace Tienda.Web.Controllers
{
    [Route("api/[Controller]")]
    public class DatosProductoController : Controller
    {
        private readonly IProductoRepository _productoRepository;

        public DatosProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public IEnumerable<ProductoViewModel> LoadMoreDrinks()
        {
            IEnumerable<Producto> dbProductos = null;

            dbProductos = _productoRepository.Productos.OrderBy(p => p.Id).Take(10);

            List<ProductoViewModel> productos = new List<ProductoViewModel>();

            foreach (var dbProducto in dbProductos)
            {
                productos.Add(MapDbDrinkToDrinkViewModel(dbProducto));
            }
            return productos;
        }

        private ProductoViewModel MapDbDrinkToDrinkViewModel(Producto dbProducto) => new ProductoViewModel()
        {
            Id = dbProducto.Id,
            Nombre = dbProducto.Nombre,
            Precio = dbProducto.Precio,
            DescripcionCorta = dbProducto.DescripcionCorta,
            ImagenMiniatura  = dbProducto.ImagenMiniatura
        };
    }
}