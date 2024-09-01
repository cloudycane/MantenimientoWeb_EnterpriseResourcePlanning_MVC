using MantenimientoWeb.Aplicacion.Servicios.UseCases;
using MantenimientoWeb.Dominio.Interfaces;
using MantenimientoWeb.Proyecto.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MantenimientoWeb.Proyecto.Controllers
{
    public class ProductosController : Controller
    {
        private readonly GetMonedasQuery _getMonedasQuery;
        private readonly GetCategoriasQuery _getCategoriasQuery;
        private readonly IProductoService _productoService;

        public ProductosController(GetMonedasQuery getMonedasQuery, GetCategoriasQuery getCategoriasQuery, IProductoService productoService)
        {
            _getCategoriasQuery = getCategoriasQuery;
            _getMonedasQuery = getMonedasQuery;
            _productoService = productoService;
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
            var viewModel = new ProductoViewModel
            {
                //SELECT LIST ITEM DE MONEDA
                MonedaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(monedas, "Id", "SimboloMoneda"),
                //SELECT LIST ITEM DE CATEGORIA 
                CategoriaSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(categorias, "Id", "Nombre")
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
