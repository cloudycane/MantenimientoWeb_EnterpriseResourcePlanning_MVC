using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetClasificacionesQuery
    {
        private readonly IClasificacionRepository _clasificacionRepository; 

        public GetClasificacionesQuery(IClasificacionRepository clasificacionRepository)
        {
            _clasificacionRepository = clasificacionRepository;
        }

        public async Task<IEnumerable<ClasificacionProductoModel>> ExecuteAsync()
        {
            var clasificaciones = await _clasificacionRepository.ObtenerListadoClasificacionAsync();
            return clasificaciones.Select(cl => new ClasificacionProductoModel { Id = cl.Id, Nombre = cl.Nombre });
        }
    }
}
