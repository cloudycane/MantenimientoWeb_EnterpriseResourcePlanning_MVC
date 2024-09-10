using MantenimientoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Interfaces
{
    public interface IInventarioRepository
    {
        Task ActualizarAsync(InventarioModel inventario);
        Task CreateAsync(InventarioModel inventario);
        Task EliminarAsync(int id);
        Task<InventarioModel> ObtenerIdAsync(int id);
        Task<IEnumerable<InventarioModel>> ObtenerListadoInventarioAsync();
        Task<IEnumerable<InventarioModel>> ObtenerTodoAsync();
    }
}
