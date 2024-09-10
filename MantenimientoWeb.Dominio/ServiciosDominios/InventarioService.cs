using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.ServiciosDominios
{
    public class InventarioService : IInventarioService
    {
        // Estado Producto 

        private readonly IEstadoProductoRepository _estadoProductoRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IInventarioRepository _inventarioRepository;

        public InventarioService(IEstadoProductoRepository estadoProductoRepository, IProductoRepository productoRepository, IInventarioRepository inventarioRepository)
        {
            _estadoProductoRepository = estadoProductoRepository;
            _productoRepository = productoRepository;
            _inventarioRepository = inventarioRepository;
        }

        public async Task CreateInventarioAsync(InventarioModel inventario)
        {
            await _inventarioRepository.CreateAsync(inventario);
        }

        public async Task<IEnumerable<InventarioModel>> ObtenerInventariosAsync()
        {
            return await _inventarioRepository.ObtenerListadoInventarioAsync();
        }

        public async Task<IEnumerable<EstadoProductoModel>> GetEstadoProductosAsync()
        {
            return await _estadoProductoRepository.ObtenerListadoEstadoProductosAsync();
        }

        public async Task<IEnumerable<ProductoModel>> GetProductosAsync()
        {
            return await _productoRepository.ObtenerListadoProductosAsync();
        }

        public async Task<InventarioModel> ObtenerInventarioPorIdAsync(int id)
        {
            return await _inventarioRepository.ObtenerIdAsync(id);
        }

        public async Task<IEnumerable<InventarioModel>> ObtenerTodosInventariosAsync()
        {
            return await _inventarioRepository.ObtenerTodoAsync();
        }

        public async Task EditarInventarioAsync (InventarioModel inventario)
        {
            await _inventarioRepository.ActualizarAsync(inventario);
        }

        public async Task EliminarInventarioAsync(int id)
        {
            await _inventarioRepository.EliminarAsync(id);
        }
    }   
}
