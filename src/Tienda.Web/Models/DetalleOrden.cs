using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Web.Models
{
    public class DetalleOrden
    {
        public int Id { get; set; }

        public int OrdenId { get; set; }

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Orden Orden { get; set; }
    }
}
