using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetTipoProductosQuery
    {
        private readonly ITipoProductoRepository _tipoProductoRepository; 

        public GetTipoProductosQuery(ITipoProductoRepository tipoProductoRepository)
        {
            _tipoProductoRepository = tipoProductoRepository;
        }

        public async Task<IEnumerable<TipoProductoModel>> ExecuteAsync()
        {
            var tipoProducto = await _tipoProductoRepository.ObtenerListadoTipoProductoAsync();
            return tipoProducto.Select(t => new TipoProductoModel { Id = t.Id, Nombre = t.Nombre});
        }
    }
}
