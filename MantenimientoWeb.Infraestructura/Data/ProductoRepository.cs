using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Infraestructura.Data
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductoModel>> ObtenerListadoProductosAsync()
        {
            return await _context.Productos.Include(c => c.Categoria).Include(m => m.Moneda).Include(cl => cl.Clasificacion).Include(t => t.Transporte).Include(e => e.Empaquetamiento).ToListAsync();
        }

        public async Task CreateAsync(ProductoModel producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
        }
    }
}
