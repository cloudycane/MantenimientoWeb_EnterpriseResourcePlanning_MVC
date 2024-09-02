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
    public class ClasificacionRepository : IClasificacionRepository
    {
        private readonly ApplicationDbContext _context;
        public ClasificacionRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<ClasificacionProductoModel>> ObtenerListadoClasificacionAsync()
        {
            return await _context.Clasificaciones.ToListAsync();
        }
    }
}
