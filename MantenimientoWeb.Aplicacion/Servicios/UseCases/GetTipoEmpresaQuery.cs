using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetTipoEmpresaQuery
    {
        private readonly ITipoEmpresaRepository _tipoEmpresaRepository; 

        public GetTipoEmpresaQuery(ITipoEmpresaRepository tipoEmpresaRepository)
        {
            _tipoEmpresaRepository = tipoEmpresaRepository;
        }

        public async Task<IEnumerable<TipoEmpresaModel>> ExecuteAsync()
        {
            var tipoEmpresa = await _tipoEmpresaRepository.ObtenerListadoTipoEmpresaAsync();

            return tipoEmpresa.Select(t => new TipoEmpresaModel { Id = t.Id, Nombre = t.Nombre });
        }
    }
}
