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
        private readonly IProductoService _productoService;
        public InventariosController(GetEstadoProductosQuery getEstadoProductosQuery, IInventarioRepository inventarioRepository, IInventarioService inventarioService, IProductoService productoService) 
        { 
            _getEstadoProductosQuery = getEstadoProductosQuery;
            _inventarioRepository = inventarioRepository;
            _inventarioService = inventarioService;
            _productoService = productoService;
        }
        // GET
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

        // GET
        public async Task<IActionResult> Detalle(int id)
        {
            var inventario = await _inventarioService.ObtenerInventarioPorIdAsync(id);

            // SELECT LIST 
            var productos = await _inventarioService.GetProductosAsync();
            var estadoProductos = await _inventarioService.GetEstadoProductosAsync();

            //
            var productoNombre = productos.FirstOrDefault(pr => pr.Id == inventario.ProductoId)?.Nombre;
            var estadoNombre = estadoProductos.FirstOrDefault(es => es.Id == inventario.EstadoProductoId)?.Nombre;

            var viewModel = new InventarioViewModel
            {
                
                Id = inventario.Id,
                ProductoId = inventario.ProductoId, 
                UnidadesDeCompraEnAño = inventario.UnidadesDeCompraEnAño, 
                Cantidad = inventario.Cantidad,
                PrecioCompra = inventario.PrecioCompra,
                //CostoPercentual = inventario.CostoPercentual, READONLY
                //CostoTotalMantenimiento = inventario.CostoTotalMantenimiento, READONLY
                //CostoPedido = inventario.CostoPedido, READONLY
                EstadoProductoId = inventario.EstadoProductoId,

            };

            ViewData["ProductoNombre"] = productoNombre;
            ViewData["EstadoNombre"] = estadoNombre;
            return View(viewModel);
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
                await _inventarioService.CreateInventarioAsync(inventario);
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

        // GET
        public async Task<IActionResult> Editar(int id)
        {
            var inventario = await _inventarioService.ObtenerInventarioPorIdAsync(id);

            var productos = await _inventarioService.GetProductosAsync() ?? new List<ProductoModel>();
            var estadoProductos = await _inventarioService.GetEstadoProductosAsync() ?? new List<EstadoProductoModel>();

            // Mapeo de InventarioModel a InventarioViewModel
            var viewModel = new InventarioViewModel
            {
                Id = inventario.Id,
                ProductoId = inventario.ProductoId,
                UnidadesDeCompraEnAño = inventario.UnidadesDeCompraEnAño,
                Cantidad = inventario.Cantidad,
                PrecioCompra = inventario.PrecioCompra,
                EstadoProductoId = inventario.EstadoProductoId,

                // SELECT LIST
                EstadoProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(estadoProductos, "Id", "Nombre"),
                ProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(productos, "Id", "Nombre")
            };

            
            return View(viewModel);
        }


        // POST

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Editar(InventarioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Mapear el ViewModel al Model
                var inventario = new InventarioModel
                {
                    Id = viewModel.Id,  
                    ProductoId = viewModel.ProductoId,
                    UnidadesDeCompraEnAño = viewModel.UnidadesDeCompraEnAño,
                    Cantidad = viewModel.Cantidad,
                    PrecioCompra = viewModel.PrecioCompra,
                    CostoPercentual = viewModel.CostoPercentual,
                    CostoTotalMantenimiento = viewModel.CostoTotalMantenimiento,
                    CostoPedido = viewModel.CostoPedido,
                    EstadoProductoId = viewModel.EstadoProductoId
                };

                
                await _inventarioService.EditarInventarioAsync(inventario);

                TempData["success"] = "El inventario ha sido actualizado con éxito.";
                return RedirectToAction("Index");
            }

            
            var productos = await _inventarioService.GetProductosAsync() ?? new List<ProductoModel>();
            var estadoProductos = await _inventarioService.GetEstadoProductosAsync() ?? new List<EstadoProductoModel>();

            viewModel.ProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(productos, "Id", "Nombre");
            viewModel.EstadoProductoSelectList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(estadoProductos, "Id", "Nombre");

            return View(viewModel);
        }




        // GET
        public async Task<IActionResult> Eliminar(int id)
        {
            var inventario = await _inventarioService.ObtenerInventarioPorIdAsync(id);
            var producto = await _inventarioService.GetProductosAsync();
            var estadoProducto = await _inventarioService.GetEstadoProductosAsync();

            //

            var productoNombre = producto.FirstOrDefault(pr => pr.Id == inventario.ProductoId)?.Nombre;
            var estadoNombre = estadoProducto.FirstOrDefault(es => es.Id == inventario.EstadoProductoId)?.Nombre;

            var viewModel = new InventarioViewModel
            {
                Id = inventario.Id,
                ProductoId = inventario.ProductoId,
                
                UnidadesDeCompraEnAño = inventario.UnidadesDeCompraEnAño,
                Cantidad = inventario.Cantidad,
                PrecioCompra = inventario.PrecioCompra,
                EstadoProductoId = inventario.EstadoProductoId,
                
            };

            //

            ViewData["ProductoNombre"] = productoNombre;
            ViewData["EstadoNombre"] = estadoNombre;
            return View(viewModel);
        }


        // POST
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmacion(int id)
        {
           await _inventarioService.EliminarInventarioAsync(id);
           TempData["success"] = "El inventario ha sido eliminado con éxito.";
           return RedirectToAction("Index");
        }
    }
}
