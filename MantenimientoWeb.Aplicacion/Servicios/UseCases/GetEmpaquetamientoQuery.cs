using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetEmpaquetamientoQuery
    {
        private readonly IEmpaquetamientoRepository _empaquetamientoRepository; 

        public GetEmpaquetamientoQuery(IEmpaquetamientoRepository empaquetamientoRepository)
        {
            _empaquetamientoRepository = empaquetamientoRepository;
        }   

        public async Task<IEnumerable<EmpaquetamientoModel>> ExecuteAsync()
        {
            var empaquetamiento = await _empaquetamientoRepository.ObtenerListadoEmpaquetamientoAsync();

            return empaquetamiento.Select(e => new EmpaquetamientoModel { Id = e.Id, Nombre = e.Nombre });
        }
    }
}
