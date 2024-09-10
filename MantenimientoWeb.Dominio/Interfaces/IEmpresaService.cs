using MantenimientoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Interfaces
{
    public interface IEmpresaService
    {
        void CreateEmpresa(EmpresaModel empresa);
        Task EditarEmpresasAsync(EmpresaModel empresa);
        Task EliminarEmpresaAsync(int id);
        Task<IEnumerable<PaisModel>> GetPaisesAsync();
        Task<IEnumerable<TipoEmpresaModel>> GetTipoEmpresasAsync();
        Task<EmpresaModel> ObtenerEmpresaPorIdAsync(int id);
        Task<IEnumerable<EmpresaModel>> ObtenerEmpresasAsync();
        Task<IEnumerable<EmpresaModel>> ObtenerTodasEmpresasAsync();
    }
}
