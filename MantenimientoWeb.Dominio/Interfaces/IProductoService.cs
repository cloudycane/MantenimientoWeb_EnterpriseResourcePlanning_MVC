using MantenimientoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Interfaces
{
    public interface IProductoService
    {
        Task<IEnumerable<ProductoModel>> BusquedaProductosAsync(string busqueda);
        Task CreateProductoAsync(ProductoModel producto);
        Task EditarProductoAsync(ProductoModel producto);
        Task EliminarInventarioProductoIdAsync(int id);
        Task EliminarProductoAsync(int id);
        Task<IEnumerable<CategoriaProductoModel>> GetCategoriasAsync();
        Task<IEnumerable<ClasificacionProductoModel>> GetClasificacionAsync();
        Task<IEnumerable<EmpaquetamientoModel>> GetEmpaquetamientosAsync();
        Task<IEnumerable<MonedaProductoModel>> GetMonedasAsync();
        Task<IEnumerable<EmpresaModel>> GetProveedoresAsync();
        Task<IEnumerable<TipoProductoModel>> GetTipoProductosAsync();
        Task<IEnumerable<TransporteModel>> GetTransporteAsync();
        Task<ProductoModel> ObtenerProductoPorIdAsync(int id);
        Task<IEnumerable<ProductoModel>> ObtenerProductosAsync();
        Task<IEnumerable<ProductoModel>> ObtenerTodosProductosAsync();
    }
}
