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
    public class EmpaquetamientoRepository : IEmpaquetamientoRepository
    {
        private readonly ApplicationDbContext _context;
        public EmpaquetamientoRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<EmpaquetamientoModel>> ObtenerListadoEmpaquetamientoAsync()
        {
            return await _context.Empaquetamientos.ToListAsync();
        }
    }
}
