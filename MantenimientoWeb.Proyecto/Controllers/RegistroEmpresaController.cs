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

        public async Task<IActionResult> Detalle(int id)
        {
            var empresa = await _empresaService.ObtenerEmpresaPorIdAsync(id);

            // SELECT LIST 

            var paises = await _empresaService.GetPaisesAsync();
            var tipoEmpresa = await _empresaService.GetTipoEmpresasAsync();

            // OBTENER NOMBRES

            var paisNombre = paises.FirstOrDefault(p => p.Id == empresa.PaisId)?.Nombre;
            var tipoEmpresaNombre = tipoEmpresa.FirstOrDefault(t => t.Id == empresa.TipoEmpresaId)?.Nombre;

            var viewModel = new EmpresaViewModel
            {
                Id = empresa.Id,
                CIF = empresa.CIF,
                RazonSocial = empresa.RazonSocial,
                CorreoElectronico = empresa.CorreoElectronico,
                PaisId = empresa.PaisId,
                Direccion = empresa.Direccion,
                TipoEmpresaId = (int)empresa.TipoEmpresaId, 

                PaisesSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(paises, "Id", "Nombre"),
                TipoEmpresaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(tipoEmpresa, "Id", "Nombre")
    
            };

            // VIEWDATAS PARA LOS NOMBRES QUE QUERAMOS OBTENER

            ViewData["PaisNombre"] = paisNombre;
            ViewData["TipoEmpresaNombre"] = tipoEmpresaNombre;

            return View(viewModel);
            
        }

        // GET: Registrar
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

        // EDITAR 

        // GET 

        public async Task<IActionResult> Editar(int id)
        {
            var empresa = await _empresaService.ObtenerEmpresaPorIdAsync(id);
            
            var paises = await _empresaService.GetPaisesAsync() ?? new List<PaisModel>();
            var tipoEmpresa = await _empresaService.GetTipoEmpresasAsync() ?? new List<TipoEmpresaModel>();

            var viewModel = new EmpresaViewModel
            {
                Id = empresa.Id,
                CIF = empresa.CIF,
                RazonSocial = empresa.RazonSocial,
                CorreoElectronico = empresa.CorreoElectronico,
                PaisId = empresa.PaisId,
                Direccion = empresa.Direccion,
                TipoEmpresaId = (int)empresa.TipoEmpresaId,

                PaisesSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(paises, "Id", "Nombre"),
                TipoEmpresaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(tipoEmpresa, "Id", "Nombre")

            };

            return View(viewModel);

        }


        // POST

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Editar(EmpresaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                // Hacer un mapeo de ViewModel a Model

                var empresa = new EmpresaModel
                {

                    Id = viewModel.Id,
                    CIF = viewModel.CIF,
                    RazonSocial = viewModel.RazonSocial,
                    CorreoElectronico = viewModel.CorreoElectronico,
                    PaisId = viewModel.PaisId,
                    Direccion = viewModel.Direccion,
                    TipoEmpresaId = viewModel.TipoEmpresaId,
                };

                await _empresaService.EditarEmpresasAsync(empresa);
                TempData["success"] = "La empresa ha sido actualizada con éxito";

                return RedirectToAction("Index");
            }

            
            return View(viewModel);
        }

        // ELIMINAR 

        // GET 

        public async Task<IActionResult> Eliminar(int id)
        {
            var empresa = await _empresaService.ObtenerEmpresaPorIdAsync(id);
            var paises = await _empresaService.GetPaisesAsync() ?? new List<PaisModel>();
            var tipoEmpresa = await _empresaService.GetTipoEmpresasAsync() ?? new List<TipoEmpresaModel>();

            var viewModel = new EmpresaViewModel
            {
                Id = empresa.Id,
                CIF = empresa.CIF,
                RazonSocial = empresa.RazonSocial,
                CorreoElectronico = empresa.CorreoElectronico,
                PaisId = empresa.PaisId,
                Direccion = empresa.Direccion,
                TipoEmpresaId = (int)empresa.TipoEmpresaId,

                PaisesSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(paises, "Id", "Nombre"),
                TipoEmpresaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(tipoEmpresa, "Id", "Nombre")

            };

            return View(viewModel);
        }

        // POST 

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> EliminarConfirmacion(int id)
        {
            await _empresaService.EliminarEmpresaAsync(id);
            TempData["success"] = "La empresa ha sido eliminada con éxito";
            return RedirectToAction("Index");
        }

    }
}
