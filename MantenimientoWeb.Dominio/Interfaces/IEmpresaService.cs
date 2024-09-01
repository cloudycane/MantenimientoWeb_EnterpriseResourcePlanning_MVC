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
        Task<IEnumerable<PaisModel>> GetPaisesAsync();
        Task<IEnumerable<TipoEmpresaModel>> GetTipoEmpresasAsync();
        Task<IEnumerable<EmpresaModel>> ObtenerEmpresasAsync();
    }
}
