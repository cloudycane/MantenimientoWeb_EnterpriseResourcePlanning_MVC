using MantenimientoWeb.Aplicacion.Servicios.UseCases;
using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using MantenimientoWeb.Proyecto.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var producto = await _productoService.ObtenerProductosAsync();

            var viewModel = new ListadoProductoModel
            {
                Productos = producto
            };

            return View(viewModel);
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
        public async Task<IActionResult> Crear(ProductoViewModel viewModel)
        {
           if(ModelState.IsValid)
            {
                var producto = new ProductoModel
                {
                    Nombre = viewModel.Nombre,
                    Description = viewModel.Descripcion,
                    FechaCreacion = viewModel.FechaCreacion,
                    FechaExpiracion = viewModel.FechaExpiracion,
                    MonedaId = viewModel.MonedaId,
                    PrecioOriginal = viewModel.PrecioOriginal,
                    LugarFabricacion = viewModel.LugarFabricacion,
                    CategoriaId = viewModel.CategoriaId,
                    ClasificacionId = viewModel.ClasificacionId,
                    CostoMantenimiento = viewModel.CostoMantenimiento,
                    NivelActual = viewModel.NivelActual,
                    PlazoEntrega = viewModel.PlazoEntrega,
                    DemandaAnual = viewModel.DemandaAnual,
                    StockActual = viewModel.StockActual,
                    ConsunmoDiarioPromedio = viewModel.ConsumoDiarioPromedio, 
                    LeadTime = viewModel.LeadTime,
                    StockSeguridad = viewModel.StockSeguridad,
                    StockMinimo = viewModel.StockMinimo,
                    EsPerecedero = viewModel.EsPerecedero,
                    EsFragil = viewModel.EsFragil,
                    RequiereRefrigacion = viewModel.RequiereRefrigacion,
                    ProductoPeligrosa = viewModel.ProductoPeligrosa,
                    VidaUtil = viewModel.VidaUtil,
                    TemperaturaAlmacenimiento = viewModel.TemperaturaAlmacenimiento,
                    InstruccionesDeManejo = viewModel.InstruccionesDeManejo,
                    TransporteId = viewModel.TransporteId,
                    EmpaquetamientoId = viewModel.EmpaquetamientoId,
                    NotasAdicionales = viewModel.NotasAdicionales,
                };
                await _productoService.CreateProductoAsync(producto);
                TempData["success"] = "El producto ha sido creado con éxito";
                return RedirectToAction("Index");   
            }
            var categorias = await _productoService.GetCategoriasAsync();
            var monedas = await _productoService.GetMonedasAsync();
            var clasificacion = await _productoService.GetClasificacionAsync();
            var transporte = await _productoService.GetTransporteAsync();
            var empaquetamiento = await _productoService.GetEmpaquetamientosAsync();

            await CargarSelectListsAsync(viewModel);
            return View(viewModel);
        
        }

        private async Task CargarSelectListsAsync(ProductoViewModel viewModel)
        {
            var monedas = await _productoService.GetMonedasAsync();
            var categorias = await _productoService.GetCategoriasAsync();
            var clasificaciones = await _productoService.GetClasificacionAsync();
            var transportes = await _productoService.GetTransporteAsync();
            var empaquetamientos = await _productoService.GetEmpaquetamientosAsync();

            viewModel.MonedaSelectList = new SelectList(monedas, "Id", "SimboloMoneda");
            viewModel.CategoriaSelectList = new SelectList(categorias, "Id", "Nombre");
            viewModel.ClasificacionSelectList = new SelectList(clasificaciones, "Id", "Nombre");
            viewModel.TransporteSelectList = new SelectList(transportes, "Id", "Vehiculo");
            viewModel.EmpaquetamientoSelectList = new SelectList(empaquetamientos, "Id", "Nombre");
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
