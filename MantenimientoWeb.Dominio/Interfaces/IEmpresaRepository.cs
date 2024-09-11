using MantenimientoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Interfaces
{
    public interface IEmpresaRepository
    {
        Task ActualizarAsync(EmpresaModel empresa);
        Task<IEnumerable<EmpresaModel>> BuscarEmpresaAsync(string busqueda);
        void Create(EmpresaModel empresa);
        Task EliminarAsync(int id);
        Task<EmpresaModel> ObtenerIdAsync(int id);
        Task<IEnumerable<EmpresaModel>> ObtenerListadoEmpresasAsync();
        Task<IEnumerable<EmpresaModel>> ObtenerTodoAsync();
    }
}
