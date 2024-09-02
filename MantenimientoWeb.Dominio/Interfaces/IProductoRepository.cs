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
        Task CreateAsync(ProductoModel producto);
        Task<IEnumerable<ProductoModel>> ObtenerListadoProductosAsync();
    }
}
