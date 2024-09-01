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
    // En algunos casos el interface de los repositorios está en el mismo archivo 

    public class MonedaRepository : IMonedaRepository
    {
        private readonly ApplicationDbContext _context;
        public MonedaRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<MonedaProductoModel>> ObtenerListadoMonedaAsync()
        {
            return await _context.Monedas.ToListAsync();
        }
    }
}
