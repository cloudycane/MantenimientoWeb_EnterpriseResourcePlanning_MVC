using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Infraestructura.Data
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly ApplicationDbContext _context;

        public EmpresaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmpresaModel>> ObtenerListadoEmpresasAsync()
        {
            return await _context.Empresas.Include(e => e.Pais).Include(t => t.TipoEmpresa).ToListAsync();
        }
        public void Create(EmpresaModel empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        public async Task<EmpresaModel> ObtenerIdAsync(int id)
        {
            return await _context.Set<EmpresaModel>().FindAsync(id);
        }

        public async Task<IEnumerable<EmpresaModel>> ObtenerTodoAsync()
        {
            return await _context.Set<EmpresaModel>().ToListAsync();
        }

        public async Task ActualizarAsync(EmpresaModel empresa)
        {
            var empresaAnterior = await _context.Empresas.FindAsync(empresa.Id);

            if (empresaAnterior != null)
            {
                empresaAnterior.CIF = empresa.CIF; 
                empresaAnterior.RazonSocial = empresa.RazonSocial;
                empresaAnterior.CorreoElectronico = empresa.CorreoElectronico;
                empresaAnterior.PaisId = empresa.PaisId;
                empresaAnterior.Direccion = empresa.Direccion;
                empresaAnterior.TipoEmpresaId = empresa.TipoEmpresaId;

                _context.Empresas.Update(empresaAnterior);

                await _context.SaveChangesAsync();
            }
        }

        public async Task EliminarAsync(int id)
        {
            var empresa = await ObtenerIdAsync(id);

            if(empresa != null)
            {
                _context.Set<EmpresaModel>().Remove(empresa);
                await _context.SaveChangesAsync();
            }
        }

        
    }
}
