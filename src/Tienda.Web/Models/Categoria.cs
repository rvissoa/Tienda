﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Web.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
