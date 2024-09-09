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
        // Producto Repository 
        private readonly IProductoRepository _productoRepository;
        // Tipo Producto Repository 
        private readonly ITipoProductoRepository _tipoProductoRepository;
        public ProductoService(IMonedaRepository monedaRepository, ICategoriaRepository categoriaRepository, IClasificacionRepository clasificacionRepository, ITransporteRepository transporteRepository, IEmpaquetamientoRepository empaquetamientoRepository, IProductoRepository productoRepository, ITipoProductoRepository tipoProductoRepository)
        {
            _monedaRepository = monedaRepository;
            _categoriaRepository = categoriaRepository;
            _clasificacionRepository = clasificacionRepository;
            _transporteRepository = transporteRepository;
            _empaquetamientoRepository = empaquetamientoRepository;
            _productoRepository = productoRepository;
            _tipoProductoRepository = tipoProductoRepository;
        }
        public async Task CreateProductoAsync(ProductoModel producto)
        {
            await _productoRepository.CreateAsync(producto);
        }

        public async Task<IEnumerable<ProductoModel>> ObtenerProductosAsync()
        {
            return await _productoRepository.ObtenerListadoProductosAsync();
        }

        public async Task<IEnumerable<TipoProductoModel>> GetTipoProductosAsync()
        {
            return await _tipoProductoRepository.ObtenerListadoTipoProductoAsync();
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

        public async Task<IEnumerable<EmpresaModel>> GetProveedoresAsync()
        {
            return await _productoRepository.ObtenerProveedoresAsync();
        }

        public async Task<ProductoModel> ObtenerProductoPorIdAsync(int id)
        {
            return await _productoRepository.ObtenerIdAsync(id);
        }

        public async Task<IEnumerable<ProductoModel>> ObtenerTodosProductosAsync()
        {
            return await _productoRepository.ObtenerTodoAsync();
        }

        public async Task EditarProductoAsync(ProductoModel producto)
        {
            await _productoRepository.ActualizarAsync(producto);
        }


        public async Task EliminarProductoAsync(int id)
        {
            await _productoRepository.EliminarAsync(id);
        }
    }
}
