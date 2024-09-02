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
        Task CreateProductoAsync(ProductoModel producto);
        Task<IEnumerable<CategoriaProductoModel>> GetCategoriasAsync();
        Task<IEnumerable<ClasificacionProductoModel>> GetClasificacionAsync();
        Task<IEnumerable<EmpaquetamientoModel>> GetEmpaquetamientosAsync();
        Task<IEnumerable<MonedaProductoModel>> GetMonedasAsync();
        Task<IEnumerable<TransporteModel>> GetTransporteAsync();
        Task<IEnumerable<ProductoModel>> ObtenerProductosAsync();
    }
}
