using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetEstadoProductosQuery
    {
        private IEstadoProductoRepository _estadoProductoRepository;

        public GetEstadoProductosQuery(IEstadoProductoRepository estadoProductoRepository)
        {
            _estadoProductoRepository = estadoProductoRepository;
        }

        public async Task<IEnumerable<EstadoProductoModel>> ExecuteAsync()
        {
            var estadoProducto = await _estadoProductoRepository.ObtenerListadoEstadoProductosAsync();
            return estadoProducto.Select(e => new EstadoProductoModel { Id = e.Id, Nombre = e.Nombre });
        }
    }
}
