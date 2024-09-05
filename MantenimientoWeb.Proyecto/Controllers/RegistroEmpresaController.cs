using MantenimientoWeb.Aplicacion.Servicios.UseCases;
using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using MantenimientoWeb.Infraestructura.Data;
using MantenimientoWeb.Proyecto.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MantenimientoWeb.Proyecto.Controllers
{
    public class RegistroEmpresaController : Controller
    {
        private readonly GetPaisesQuery _getPaisesQuery;
        private readonly GetTipoEmpresaQuery _getTipoEmpresaQuery;
        private readonly IEmpresaService _empresaService;

        private readonly ApplicationDbContext _context;
        

        public RegistroEmpresaController(GetPaisesQuery getPaisesQuery, IEmpresaService empresaService, GetTipoEmpresaQuery getTipoEmpresaQuery)
        {
            _getPaisesQuery = getPaisesQuery;
            _empresaService = empresaService;
            _getTipoEmpresaQuery = getTipoEmpresaQuery;
        }

        
        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 4)
        {

            var empresas = await _empresaService.ObtenerEmpresasAsync();       

            var paginatedList = empresas.Skip((pageNumber -1)*pageSize).Take(pageSize).ToList();

            var viewModel = new ListadoEmpresasViewModel
            {
                Empresas = paginatedList, 
                PaginaActual = pageNumber,
                PaginasTotal = (int)Math.Ceiling(empresas.Count() / (double)pageSize)
            };
            return View(viewModel);
        }

        // GET: /Registrar
        public async Task<IActionResult> Registrar()
        {
            var paises = await _getPaisesQuery.ExecuteAsync();
            var tipoEmpresas = await _getTipoEmpresaQuery.ExecuteAsync();
            var viewModel = new EmpresaViewModel
            {
                // SELECT LIST ITEM DE PAIS
                PaisesSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(paises, "Id", "Nombre"), 
                // SELECT LIST ITEM DE TIPO EMPRESA
                TipoEmpresaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(tipoEmpresas, "Id", "Nombre")
            };

            ViewBag.Paises = paises.ToDictionary(p => p.Id);

            return View(viewModel);
        }

        // POST: /Registrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrar(EmpresaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // VAMOS A HACER UN MAPEO DEL VIEWMODEL A LA ENTIDAD
                var empresa = new EmpresaModel
                {
                    CIF = viewModel.CIF,
                    RazonSocial = viewModel.RazonSocial,
                    CorreoElectronico = viewModel.CorreoElectronico,
                    PaisId = viewModel.PaisId,
                    Direccion = viewModel.Direccion,
                    TipoEmpresaId = viewModel.TipoEmpresaId,
                };

                TempData["success"] = "La empresa ha sido creada con éxito";
                _empresaService.CreateEmpresa(empresa);
                

                return RedirectToAction("Index");
            }

            var paises = await _empresaService.GetPaisesAsync();
            var tipoEmpresas = await _empresaService.GetTipoEmpresasAsync();
            viewModel.PaisesSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(paises, "Id", "Nombre");
            viewModel.TipoEmpresaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(tipoEmpresas, "Id", "Nombre");
            return View(viewModel);
        }
    }
}
