using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Data;
using Tienda.Web.Interfaces;
using Tienda.Web.Models;

namespace Tienda.Web.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly TiendaDbContext _tiendaDbContext;

        public CategoriaRepository(TiendaDbContext tiendaDbContext)
        {
            _tiendaDbContext = tiendaDbContext;
        }
        public IEnumerable<Categoria> Categorias => _tiendaDbContext.Categorias;
    }
}
