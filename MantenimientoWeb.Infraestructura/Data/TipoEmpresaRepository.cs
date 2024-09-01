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
    public class TipoEmpresaRepository : ITipoEmpresaRepository
    {
        private readonly ApplicationDbContext _context;

        public TipoEmpresaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TipoEmpresaModel>> ObtenerListadoTipoEmpresaAsync()
        {
            return await _context.TipoEmpresas.ToListAsync();
        }


    }
}
