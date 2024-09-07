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
    public class InventarioRepository : IInventarioRepository
    {
        private readonly ApplicationDbContext _context;

        public InventarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InventarioModel>> ObtenerListadoInventarioAsync()
        {
            return await _context.Inventario.Include(p => p.Producto).Include(e => e.EstadoProducto).Include(m => m.Producto.Moneda).ToListAsync();
        }

        public async Task CreateAsync(InventarioModel inventario)
        {
            await _context.Inventario.AddAsync(inventario);
            await _context.SaveChangesAsync();
        }
    }
}
