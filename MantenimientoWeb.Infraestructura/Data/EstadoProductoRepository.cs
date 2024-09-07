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
    public class EstadoProductoRepository : IEstadoProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public EstadoProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EstadoProductoModel>> ObtenerListadoEstadoProductosAsync()
        {
            return await _context.EstadoProductos.ToListAsync();
        }
    }
}
