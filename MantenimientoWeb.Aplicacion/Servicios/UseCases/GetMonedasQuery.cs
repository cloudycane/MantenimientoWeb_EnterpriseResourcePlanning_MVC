using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetMonedasQuery
    {
        private readonly IMonedaRepository _monedaRepository; 

        public GetMonedasQuery(IMonedaRepository monedaRepository)
        {
            _monedaRepository = monedaRepository;
        }

        public async Task<IEnumerable<MonedaProductoModel>> ExecuteAsync()
        {
            var monedas = await _monedaRepository.ObtenerListadoMonedaAsync();
            return monedas.Select(m => new MonedaProductoModel { Id = m.Id, SimboloMoneda = m.SimboloMoneda });
        }
    }
}
