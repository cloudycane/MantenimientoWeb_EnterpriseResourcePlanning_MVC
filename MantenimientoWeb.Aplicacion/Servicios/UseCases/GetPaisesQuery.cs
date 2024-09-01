using MantenimientoWeb.Aplicacion.DTOs;
using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetPaisesQuery
    {
        private readonly IPaisRepository _paisRepository; 

        public GetPaisesQuery(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public async Task<IEnumerable<PaisModel>> ExecuteAsync()
        {
            var paises = await _paisRepository.ObtenerListadoPaisAsync();

            return paises.Select(p => new PaisModel { Id = p.Id, Nombre = p.Nombre });
        }
    }
}
