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
    public class PaisRepository : IPaisRepository
    {
        private readonly ApplicationDbContext _context;
        public PaisRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaisModel>> ObtenerListadoPaisAsync()
        {
            return await _context.Paises.ToListAsync();
        }


    }


}
