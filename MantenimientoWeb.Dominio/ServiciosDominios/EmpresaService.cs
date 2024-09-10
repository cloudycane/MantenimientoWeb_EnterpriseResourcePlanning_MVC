
using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.ServiciosDominios
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IPaisRepository _paisRepository;
        private readonly ITipoEmpresaRepository _tipoEmpresaRepository;
       
        public EmpresaService(IEmpresaRepository empresaRepository, IPaisRepository paisRepository, ITipoEmpresaRepository tipoEmpresaRepository)
        {
            _empresaRepository = empresaRepository;
            _paisRepository = paisRepository;
            _tipoEmpresaRepository = tipoEmpresaRepository;
            
        }

        public void CreateEmpresa(EmpresaModel empresa)
        {
            //Business Logic 
            _empresaRepository.Create(empresa);
        }

        public async Task<IEnumerable<PaisModel>> GetPaisesAsync()
        {
            return await _paisRepository.ObtenerListadoPaisAsync();
        }

        public async Task<IEnumerable<TipoEmpresaModel>> GetTipoEmpresasAsync()
        {
            return await _tipoEmpresaRepository.ObtenerListadoTipoEmpresaAsync();
        }

        public async Task<EmpresaModel> ObtenerEmpresaPorIdAsync(int id)
        {
            return await _empresaRepository.ObtenerIdAsync(id);
        }


        public async Task<IEnumerable<EmpresaModel>> ObtenerEmpresasAsync()
        {
            return await _empresaRepository.ObtenerListadoEmpresasAsync();
        }

        public async Task<IEnumerable<EmpresaModel>> ObtenerTodasEmpresasAsync()
        {
            return await _empresaRepository.ObtenerTodoAsync();
        }

        public async Task EditarEmpresasAsync(EmpresaModel empresa)
        {
            await _empresaRepository.ActualizarAsync(empresa);
        }

        public async Task EliminarEmpresaAsync(int id)
        {
            await _empresaRepository.EliminarAsync(id);
        }
    }
}
