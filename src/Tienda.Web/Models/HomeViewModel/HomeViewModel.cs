using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Web.Models.HomeViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Producto> PreferenciaProductos { get; set; }
    }
}
