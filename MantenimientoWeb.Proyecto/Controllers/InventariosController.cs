using MantenimientoWeb.Aplicacion.Servicios.UseCases;
using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using MantenimientoWeb.Dominio.ServiciosDominios;
using MantenimientoWeb.Proyecto.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MantenimientoWeb.Proyecto.Controllers
{
    public class InventariosController : Controller
    {

        private readonly GetEstadoProductosQuery _getEstadoProductosQuery; 
        private readonly IInventarioRepository _inventarioRepository;
        private readonly IInventarioService _inventarioService;

        public InventariosController(GetEstadoProductosQuery getEstadoProductosQuery, IInventarioRepository inventarioRepository, IInventarioService inventarioService) 
        { 
            _getEstadoProductosQuery = getEstadoProductosQuery;
            _inventarioRepository = inventarioRepository;
            _inventarioService = inventarioService;
        }
        // GET: InventariosController
        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 4)
        {
            var inventario = await _inventarioService.ObtenerInventariosAsync();

            var paginatedList = inventario.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new ListadoInventarioModel
            {
                Inventarios = paginatedList, 
                PaginaActual = pageNumber, 
                PaginasTotal = (int)Math.Ceiling(inventario.Count() / (double)pageSize)
            };
            return View(viewModel);
        }

        // GET: InventariosController/Details/5
        public ActionResult Detalle(int id)
        {
            return View();
        }

        // GET: InventariosController/Create
        public async Task<IActionResult> Crear()
        {
            var productos = await _inventarioService.GetProductosAsync();
            var estadoProductos = await _getEstadoProductosQuery.ExecuteAsync();

            var viewModel = new InventarioViewModel
            {
                ProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(productos, "Id", "Nombre"), 
                EstadoProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(estadoProductos, "Id", "Nombre")
            };

            return View(viewModel);
        }

        // POST: InventariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Crear(InventarioViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var inventario = new InventarioModel
                {
                    ProductoId = viewModel.ProductoId,
                    UnidadesDeCompraEnAño = viewModel.UnidadesDeCompraEnAño,
                    Cantidad = viewModel.Cantidad,
                    PrecioCompra = viewModel.PrecioCompra,
                    CostoPercentual = viewModel.CostoPercentual,
                    CostoTotalMantenimiento = viewModel.CostoTotalMantenimiento,
                    CostoPedido = viewModel.CostoPedido,
                    EstadoProductoId = viewModel.EstadoProductoId
                };
                await _inventarioRepository.CreateAsync(inventario);
                TempData["success"] = "El inventario ha sido creado con éxito.";
                return RedirectToAction("Index");

            }
            var productos = await _inventarioService.GetProductosAsync();
            var estadoProductos = await _getEstadoProductosQuery.ExecuteAsync();
            await CargarSelectListsAsync(viewModel);
            return View(viewModel);

        }

        private async Task CargarSelectListsAsync(InventarioViewModel viewModel)
        {
            var productos = await _inventarioService.GetProductosAsync();
            var estadoProductos = await _getEstadoProductosQuery.ExecuteAsync();

            viewModel.ProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(productos, "Id", "Nombre");
            viewModel.EstadoProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(estadoProductos, "Id", "Nombre");

        }
        // GET: InventariosController/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: InventariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, IFormCollection collection)
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

        // GET: InventariosController/Delete/5
        public ActionResult Eliminar(int id)
        {
            return View();
        }

        // POST: InventariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(int id, IFormCollection collection)
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
