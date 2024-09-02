using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetTransportesQuery
    {
        private readonly ITransporteRepository _transporteRepository;

        public GetTransportesQuery(ITransporteRepository transporteRepository)
        {
            _transporteRepository = transporteRepository;
        }   

        public async Task<IEnumerable<TransporteModel>> ExecuteAsync()
        {
            var transportes = await _transporteRepository.ObtenerListadoTransporteAsync(); 
            return transportes.Select(t => new TransporteModel { Id = t.Id, Vehiculo = t.Vehiculo });
        }
    }
}
