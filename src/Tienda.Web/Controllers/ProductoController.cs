using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Web.Interfaces;
using Tienda.Web.Models;
using Tienda.Web.Models.ListaProductosViewModels;

namespace Tienda.Web.Controllers
{
    public class ProductoController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        */

        private readonly IProductoRepository _productoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public ProductoController(IProductoRepository productoRepository, ICategoriaRepository categoryRepository)
        {
            _productoRepository = productoRepository;
            _categoriaRepository = categoryRepository;
        }

        public IActionResult List(string categoria)
        {
            string _categoria = categoria;
            IEnumerable<Producto> productos;
            string categoriaActual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                productos = _productoRepository.Productos.OrderBy(p => p.Id);
                categoriaActual = "Todos los productos";
            }
            else
            {
                if (string.Equals("Hogar", _categoria, StringComparison.OrdinalIgnoreCase))
                    productos = _productoRepository.Productos.Where(p => p.Categoria.Nombre.Equals("Hogar")).OrderBy(p => p.Nombre);
                else
                    productos = _productoRepository.Productos.Where(p => p.Categoria.Nombre.Equals("Moda")).OrderBy(p => p.Nombre);

                categoriaActual = _categoria;
            }

            return View(new ListaProductosViewModel
            {
                Productos = productos,
                CategoriaActual = categoriaActual
            });
        }

        public IActionResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Producto> productos;
            string categoriaActual = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                productos = _productoRepository.Productos.OrderBy(p => p.Id);
            }
            else
            {
                productos = _productoRepository.Productos.Where(p => p.Nombre.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Producto/List.cshtml", new ListaProductosViewModel { Productos = productos, CategoriaActual = "Todos los productos" });
        }

        public IActionResult Details(int productoId)
        {
            var producto = _productoRepository.Productos.FirstOrDefault(d => d.Id == productoId);
            if (producto == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(producto);
        }
    }
}