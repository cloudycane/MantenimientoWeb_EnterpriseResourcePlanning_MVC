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
        // Clasificaciones Repository 
        private readonly IClasificacionRepository _clasificacionRepository;
        // Transporte Repository 
        private readonly ITransporteRepository _transporteRepository; 
        // Empaquetamiento Repository 
        private readonly IEmpaquetamientoRepository _empaquetamientoRepository;
        public ProductoService(IMonedaRepository monedaRepository, ICategoriaRepository categoriaRepository, IClasificacionRepository clasificacionRepository, ITransporteRepository transporteRepository, IEmpaquetamientoRepository empaquetamientoRepository)
        {
            _monedaRepository = monedaRepository;
            _categoriaRepository = categoriaRepository;
            _clasificacionRepository = clasificacionRepository;
            _transporteRepository = transporteRepository;
            _empaquetamientoRepository = empaquetamientoRepository;
        }

        public async Task<IEnumerable<MonedaProductoModel>> GetMonedasAsync()
        {
            return await _monedaRepository.ObtenerListadoMonedaAsync();
        }
        public async Task<IEnumerable<CategoriaProductoModel>> GetCategoriasAsync()
        {
            return await _categoriaRepository.ObtenerListadoCategoriaAsync();
        }
     
        public async Task<IEnumerable<ClasificacionProductoModel>> GetClasificacionAsync()
        {
            return await _clasificacionRepository.ObtenerListadoClasificacionAsync();
        }

        public async Task<IEnumerable<TransporteModel>> GetTransporteAsync()
        {
            return await _transporteRepository.ObtenerListadoTransporteAsync();
        }

        public async Task<IEnumerable<EmpaquetamientoModel>> GetEmpaquetamientosAsync()
        {
            return await _empaquetamientoRepository.ObtenerListadoEmpaquetamientoAsync();
        }
    }
}
