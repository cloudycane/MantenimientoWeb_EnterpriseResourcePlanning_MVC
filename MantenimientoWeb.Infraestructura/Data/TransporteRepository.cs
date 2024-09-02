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
    public class TransporteRepository : ITransporteRepository
    {
        private readonly ApplicationDbContext _context; 
        public TransporteRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<TransporteModel>> ObtenerListadoTransporteAsync()
        {
            return await _context.Transportes.ToListAsync();
        }

    }
}
