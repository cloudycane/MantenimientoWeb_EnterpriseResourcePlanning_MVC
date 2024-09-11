using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.Servicios.UseCases
{
    public class GetCategoriasQuery
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public GetCategoriasQuery(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
 

        public async Task<IEnumerable<CategoriaProductoModel>> ExecuteAsync()
        {
            var categoria = await _categoriaRepository.ObtenerListadoCategoriaAsync();

            return categoria.Select(t => new CategoriaProductoModel { Id = t.Id, Nombre = t.Nombre });
        }
    }
}
