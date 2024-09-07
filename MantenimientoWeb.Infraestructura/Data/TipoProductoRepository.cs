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
    public class TipoProductoRepository : ITipoProductoRepository
    {
        private readonly ApplicationDbContext _context;
        public TipoProductoRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<TipoProductoModel>> ObtenerListadoTipoProductoAsync()
        {
            return await _context.TipoProductos.ToListAsync();
        }
    }
}
