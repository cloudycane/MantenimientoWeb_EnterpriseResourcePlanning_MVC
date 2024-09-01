using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.ServiciosDominios
{
    public class ProductoService : IProductoService
    {
        // Moneda Repository 
        private readonly IMonedaRepository _monedaRepository;
        // Categoria Repository
        private readonly ICategoriaRepository _categoriaRepository;
        public ProductoService(IMonedaRepository monedaRepository, ICategoriaRepository categoriaRepository)
        {
            _monedaRepository = monedaRepository;
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<MonedaProductoModel>> GetMonedasAsync()
        {
            return await _monedaRepository.ObtenerListadoMonedaAsync();
        }
        public async Task<IEnumerable<CategoriaProductoModel>> GetCategoriasAsync()
        {
            return await _categoriaRepository.ObtenerListadoCategoriaAsync();
        }
     
    }
}
