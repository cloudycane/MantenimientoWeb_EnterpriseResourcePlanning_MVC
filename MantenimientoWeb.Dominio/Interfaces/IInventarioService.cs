using MantenimientoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Interfaces
{
    public interface IInventarioService
    {
        Task CreateInventarioAsync(InventarioModel inventario);
        Task<IEnumerable<EstadoProductoModel>> GetEstadoProductosAsync();
        Task<IEnumerable<ProductoModel>> GetProductosAsync();
        Task<IEnumerable<InventarioModel>> ObtenerInventariosAsync();
    }
}
