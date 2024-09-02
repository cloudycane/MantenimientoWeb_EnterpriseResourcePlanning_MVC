using MantenimientoWeb.Aplicacion.Servicios.UseCases;
using MantenimientoWeb.Dominio.Interfaces;
using MantenimientoWeb.Proyecto.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MantenimientoWeb.Proyecto.Controllers
{
    public class ProductosController : Controller
    {
        private readonly GetEmpaquetamientoQuery _getEmpaquetamientoQuery;
        private readonly GetClasificacionesQuery _getClasificacionesQuery;
        private readonly GetMonedasQuery _getMonedasQuery;
        private readonly GetCategoriasQuery _getCategoriasQuery;
        private readonly GetTransportesQuery _getTransportesQuery; 
        private readonly IProductoService _productoService;

        public ProductosController(GetMonedasQuery getMonedasQuery, GetCategoriasQuery getCategoriasQuery, IProductoService productoService, GetClasificacionesQuery getClasificacionesQuery, GetTransportesQuery getTransportesQuery, GetEmpaquetamientoQuery getEmpaquetamientoQuery)
        {
            _getCategoriasQuery = getCategoriasQuery;
            _getMonedasQuery = getMonedasQuery;
            _productoService = productoService;
            _getClasificacionesQuery = getClasificacionesQuery;
            _getTransportesQuery = getTransportesQuery;
            _getEmpaquetamientoQuery = getEmpaquetamientoQuery;
        }


        // GET: ProductosController
        public async Task<IActionResult> Index()
        {
            var monedas = await _productoService.GetMonedasAsync();

            var viewModel = new ListadoProductoModel
            {
                //Productos = productos
            };

            return View();
        }

        // GET: ProductosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductosController/Create
        public async Task<IActionResult> Crear()
        {
            var monedas = await _getMonedasQuery.ExecuteAsync();
            var categorias = await _getCategoriasQuery.ExecuteAsync();
            var clasificaciones = await _getClasificacionesQuery.ExecuteAsync();
            var transportes = await _getTransportesQuery.ExecuteAsync();
            var empaquetamientos = await _getEmpaquetamientoQuery.ExecuteAsync();
            
            var viewModel = new ProductoViewModel
            {
                //SELECT LIST ITEM DE MONEDA
                MonedaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(monedas, "Id", "SimboloMoneda"),
                //SELECT LIST ITEM DE CATEGORIA 
                CategoriaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(categorias, "Id", "Nombre"),
                //SELECT LIST ITEM DE CLASIFICACIONES
                ClasificacionSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(clasificaciones, "Id", "Nombre"),
                //SELECT LIST ITEM DE TRANSPORTES 
                TransporteSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(transportes, "Id", "Vehiculo"),
                //SELECT LIST ITEM DE EMPAQUETAMIENTOS
                EmpaquetamientoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(empaquetamientos, "Id", "Nombre")
            };

            return View(viewModel);
        }

        // POST: ProductosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
