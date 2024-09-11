using MantenimientoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Interfaces
{
    public interface IProductoRepository
    {
        Task ActualizarAsync(ProductoModel producto);
        Task<IEnumerable<ProductoModel>> BuscarProductoAsync(string busqueda);
        Task CreateAsync(ProductoModel producto);
        Task EliminarAsync(int id);
        Task EliminarInventarioPorProductoIdAsync(int productoId);
        Task<ProductoModel> ObtenerIdAsync(int id);
        Task<IEnumerable<ProductoModel>> ObtenerListadoProductosAsync();
        Task<IEnumerable<EmpresaModel>> ObtenerProveedoresAsync();
        Task<IEnumerable<ProductoModel>> ObtenerTodoAsync();
    }
}
