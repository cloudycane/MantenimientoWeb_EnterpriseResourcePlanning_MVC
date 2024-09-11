using MantenimientoWeb.Aplicacion.Servicios.UseCases;
using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using MantenimientoWeb.Proyecto.ViewModels;
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
        private readonly GetTipoEmpresaQuery _getTipoEmpresaQuery;
        private readonly GetTipoProductosQuery _getTipoProductosQuery;
        private readonly IProductoService _productoService;

        public ProductosController(GetMonedasQuery getMonedasQuery, GetCategoriasQuery getCategoriasQuery, IProductoService productoService, GetClasificacionesQuery getClasificacionesQuery, GetTransportesQuery getTransportesQuery, GetEmpaquetamientoQuery getEmpaquetamientoQuery, GetTipoEmpresaQuery getTipoEmpresaQuery, GetTipoProductosQuery getTipoProductosQuery)
        {
            _getCategoriasQuery = getCategoriasQuery;
            _getMonedasQuery = getMonedasQuery;
            _productoService = productoService;
            _getClasificacionesQuery = getClasificacionesQuery;
            _getTransportesQuery = getTransportesQuery;
            _getEmpaquetamientoQuery = getEmpaquetamientoQuery;
            _getTipoEmpresaQuery = getTipoEmpresaQuery;
            _getTipoProductosQuery = getTipoProductosQuery;
        }


        // GET: ProductosController
        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 4)
        {
            var producto = await _productoService.ObtenerProductosAsync();

            var paginatedList = producto.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
          
            if (producto == null)
            {
                producto = new List<ProductoModel>();
            }

            var viewModel = new ListadoProductoModel
            {
                Productos = paginatedList,
                PaginaActual = pageNumber,
                PaginasTotal = (int)Math.Ceiling(producto.Count() / (double)pageSize)
            };

            return View(viewModel);
        }

        // GET: ProductosController/Detalle
        public async Task<IActionResult> Detalle(int id)
        {
            var producto = await _productoService.ObtenerProductoPorIdAsync(id);
            
            var monedas = await _productoService.GetMonedasAsync() ?? new List<MonedaProductoModel>();
            var categorias = await _productoService.GetCategoriasAsync() ?? new List<CategoriaProductoModel>();
            var clasificaciones = await _productoService.GetClasificacionAsync() ?? new List<ClasificacionProductoModel>();
            var transportes = await _productoService.GetTransporteAsync() ?? new List<TransporteModel>();
            var empaquetamientos = await _productoService.GetEmpaquetamientosAsync() ?? new List<EmpaquetamientoModel>();
            var proveedores = await _productoService.GetProveedoresAsync() ?? new List<EmpresaModel>();
            var tipoProductos = await _productoService.GetTipoProductosAsync() ?? new List<TipoProductoModel>();

            //
            var categoriaNombre = categorias.FirstOrDefault(c => c.Id == producto.CategoriaId)?.Nombre;
            var monedaSimbolo = monedas.FirstOrDefault(m => m.Id == producto.MonedaId)?.SimboloMoneda;
            var clasificacionNombre = clasificaciones.FirstOrDefault(cl => cl.Id == producto.ClasificacionId)?.Nombre;
            var proveedorNombre = proveedores.FirstOrDefault(p => p.Id == producto.ProveedorId)?.RazonSocial;
            var tipoProductoNombre = tipoProductos.FirstOrDefault(tp => tp.Id == producto.TipoProductoId)?.Nombre;
            var tipoTransporteNombre = transportes.FirstOrDefault(tr => tr.Id == producto.TransporteId)?.Vehiculo;
            var tipoEmpaquetamientoNombre = empaquetamientos.FirstOrDefault(te => te.Id == producto.EmpaquetamientoId)?.Nombre;

            var viewModel = new ProductoViewModel
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Description,
                FechaCreacion = producto.FechaCreacion,
                FechaExpiracion = producto.FechaExpiracion,
                MonedaId = producto.MonedaId,
                PrecioOriginal = producto.PrecioOriginal,
                LugarFabricacion = producto.LugarFabricacion,
                CategoriaId = producto.CategoriaId,
                ClasificacionId = producto.ClasificacionId,
                CostoMantenimiento = producto.CostoMantenimiento,
                NivelActual = producto.NivelActual,
                PlazoEntrega = producto.PlazoEntrega,
                DemandaAnual = producto.DemandaAnual,
                StockActual = producto.StockActual,
                ConsumoDiarioPromedio = producto.ConsunmoDiarioPromedio,
                LeadTime = producto.LeadTime,
                StockSeguridad = producto.StockSeguridad,
                //StockMinimo = producto.StockMinimo es READ-ONLY
                EsPerecedero = producto.EsPerecedero,
                EsFragil = producto.EsFragil,
                RequiereRefrigacion = producto.RequiereRefrigacion,
                ProductoPeligrosa = producto.ProductoPeligrosa,
                VidaUtil = producto.VidaUtil,
                TemperaturaAlmacenimiento = producto.TemperaturaAlmacenimiento,
                InstruccionesDeManejo = producto.InstruccionesDeManejo,
                TransporteId = producto.TransporteId,
                EmpaquetamientoId = producto.EmpaquetamientoId,
                NotasAdicionales = producto.NotasAdicionales,
                ProveedorId = producto.ProveedorId,
                TipoProductoId = producto.TipoProductoId,
                


                TipoProductoSelectList = new SelectList(tipoProductos, "Id", "Nombre"),
                ProveedorSelectList = new SelectList(proveedores, "Id", "RazonSocial"),
                MonedaSelectList = new SelectList(monedas, "Id", "SimboloMoneda"),
                CategoriaSelectList = new SelectList(categorias, "Id", "Nombre"),
                ClasificacionSelectList = new SelectList(clasificaciones, "Id", "Nombre"),
                TransporteSelectList = new SelectList(transportes, "Id", "Vehiculo"),
                EmpaquetamientoSelectList = new SelectList(empaquetamientos, "Id", "Nombre")
            
            
            };

            // 

            ViewData["CategoriaNombre"] = categoriaNombre;
            ViewData["MonedaSimbolo"] = monedaSimbolo;
            ViewData["ClasificacionNombre"] = clasificacionNombre;
            ViewData["RazonSocial"] = proveedorNombre;
            ViewData["TipoProductoNombre"] = tipoProductoNombre;
            ViewData["TransporteNombre"] = tipoTransporteNombre;
            ViewData["EmpaquetamientoNombre"] = tipoEmpaquetamientoNombre;

            return View(viewModel);
        }

        // GET: ProductosController/Crear
        public async Task<IActionResult> Crear()
        {
            var monedas = await _getMonedasQuery.ExecuteAsync();
            var categorias = await _getCategoriasQuery.ExecuteAsync();
            var clasificaciones = await _getClasificacionesQuery.ExecuteAsync();
            var transportes = await _getTransportesQuery.ExecuteAsync();
            var empaquetamientos = await _getEmpaquetamientoQuery.ExecuteAsync();
            var tipoProducto = await _getTipoProductosQuery.ExecuteAsync();
            var proveedor = await _productoService.GetProveedoresAsync();


            var viewModel = new ProductoViewModel
            {
                //SELECT LIST ITEM DE TIPO PRODUCTOS
                TipoProductoSelectList = new SelectList(tipoProducto, "Id", "Nombre"),
                //SELECT LIST ITEM DE PROVEEDORES 
                ProveedorSelectList = new SelectList(proveedor, "Id", "RazonSocial"),
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
                    ProveedorId = viewModel.ProveedorId,
                    TipoProductoId = viewModel.TipoProductoId
                    
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
            var proveedor = await _productoService.GetProveedoresAsync();
            var tipoProducto = _productoService.GetTipoProductosAsync();

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
            var proveedor = await _productoService.GetProveedoresAsync();
            var tipoProducto = await _productoService.GetTipoProductosAsync();

            viewModel.MonedaSelectList = new SelectList(monedas, "Id", "SimboloMoneda");
            viewModel.CategoriaSelectList = new SelectList(categorias, "Id", "Nombre");
            viewModel.ClasificacionSelectList = new SelectList(clasificaciones, "Id", "Nombre");
            viewModel.TransporteSelectList = new SelectList(transportes, "Id", "Vehiculo");
            viewModel.EmpaquetamientoSelectList = new SelectList(empaquetamientos, "Id", "Nombre");
            viewModel.ProveedorSelectList = new SelectList(proveedor, "Id", "RazonSocial");
            viewModel.TipoProductoSelectList = new SelectList(tipoProducto, "Id", "Nombre");
        }

        // GET 
        public async Task<IActionResult> Editar(int id)
        {
            var producto = await _productoService.ObtenerProductoPorIdAsync(id);

            var monedas = await _productoService.GetMonedasAsync() ?? new List<MonedaProductoModel>();
            var categorias = await _productoService.GetCategoriasAsync() ?? new List<CategoriaProductoModel>();
            var clasificaciones = await _productoService.GetClasificacionAsync() ?? new List<ClasificacionProductoModel>();
            var transportes = await _productoService.GetTransporteAsync() ?? new List<TransporteModel>();
            var empaquetamientos = await _productoService.GetEmpaquetamientosAsync() ?? new List<EmpaquetamientoModel>();
            var proveedores = await _productoService.GetProveedoresAsync() ?? new List<EmpresaModel>();
            var tipoProductos = await _productoService.GetTipoProductosAsync() ?? new List<TipoProductoModel>();

            var viewModel = new ProductoViewModel
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Description,
                FechaCreacion = producto.FechaCreacion,
                FechaExpiracion = producto.FechaExpiracion,
                MonedaId = producto.MonedaId,
                PrecioOriginal = producto.PrecioOriginal,
                LugarFabricacion = producto.LugarFabricacion,
                CategoriaId = producto.CategoriaId,
                ClasificacionId = producto.ClasificacionId,
                CostoMantenimiento = producto.CostoMantenimiento,
                NivelActual = producto.NivelActual,
                PlazoEntrega = producto.PlazoEntrega,
                DemandaAnual = producto.DemandaAnual,
                StockActual = producto.StockActual,
                ConsumoDiarioPromedio = producto.ConsunmoDiarioPromedio,
                LeadTime = producto.LeadTime,
                StockSeguridad = producto.StockSeguridad,
                //StockMinimo = producto.StockMinimo es READ-ONLY
                EsPerecedero = producto.EsPerecedero,
                EsFragil = producto.EsFragil,
                RequiereRefrigacion = producto.RequiereRefrigacion,
                ProductoPeligrosa = producto.ProductoPeligrosa,
                VidaUtil = producto.VidaUtil,
                TemperaturaAlmacenimiento = producto.TemperaturaAlmacenimiento,
                InstruccionesDeManejo = producto.InstruccionesDeManejo,
                TransporteId = producto.TransporteId,
                EmpaquetamientoId = producto.EmpaquetamientoId,
                NotasAdicionales = producto.NotasAdicionales,
                ProveedorId = producto.ProveedorId,
                TipoProductoId = producto.TipoProductoId,


                TipoProductoSelectList = new SelectList(tipoProductos, "Id", "Nombre"),
                ProveedorSelectList = new SelectList(proveedores, "Id", "RazonSocial"),
                MonedaSelectList = new SelectList(monedas, "Id", "SimboloMoneda"),
                CategoriaSelectList = new SelectList(categorias, "Id", "Nombre"),
                ClasificacionSelectList = new SelectList(clasificaciones, "Id", "Nombre"),
                TransporteSelectList = new SelectList(transportes, "Id", "Vehiculo"),
                EmpaquetamientoSelectList = new SelectList(empaquetamientos, "Id", "Nombre")
            };

            return View(viewModel);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(ProductoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Hacer un mapeo de ViewModel al Modelo
                var producto = new ProductoModel
                {
                    Id = viewModel.Id,
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
                    ProveedorId = viewModel.ProveedorId,
                    TipoProductoId = viewModel.TipoProductoId
                };

                // Actualizar
                await _productoService.EditarProductoAsync(producto);
                TempData["success"] = "El producto ha sido actualizado con éxito";
                return RedirectToAction("Index");
            }

            // Una función para RESETEAR select lists.
            await CargarSelectListsAsync(viewModel);
            return View(viewModel);
        }


        // GET: ProductosController
        // Hay que mapear ViewModel a ProductoModel o Vice Versa!!!!
        public async Task<IActionResult> Eliminar(int id)
        {
            var producto = await _productoService.ObtenerProductoPorIdAsync(id);


            var monedas = await _productoService.GetMonedasAsync() ?? new List<MonedaProductoModel>();
            var categorias = await _productoService.GetCategoriasAsync() ?? new List<CategoriaProductoModel>();
            var clasificaciones = await _productoService.GetClasificacionAsync() ?? new List<ClasificacionProductoModel>();
            var transportes = await _productoService.GetTransporteAsync() ?? new List<TransporteModel>();
            var empaquetamientos = await _productoService.GetEmpaquetamientosAsync() ?? new List<EmpaquetamientoModel>();
            var proveedores = await _productoService.GetProveedoresAsync() ?? new List<EmpresaModel>();
            var tipoProductos = await _productoService.GetTipoProductosAsync() ?? new List<TipoProductoModel>();

            var viewModel = new ProductoViewModel
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Description,
                FechaCreacion = producto.FechaCreacion,
                FechaExpiracion = producto.FechaExpiracion,
                MonedaId = producto.MonedaId,
                PrecioOriginal = producto.PrecioOriginal,
                LugarFabricacion = producto.LugarFabricacion,
                CategoriaId = producto.CategoriaId,
                ClasificacionId = producto.ClasificacionId,
                CostoMantenimiento = producto.CostoMantenimiento,
                NivelActual = producto.NivelActual,
                PlazoEntrega = producto.PlazoEntrega,
                DemandaAnual = producto.DemandaAnual,
                StockActual = producto.StockActual,
                ConsumoDiarioPromedio = producto.ConsunmoDiarioPromedio,
                LeadTime = producto.LeadTime,
                StockSeguridad = producto.StockSeguridad,
                //StockMinimo = producto.StockMinimo es READ-ONLY
                EsPerecedero = producto.EsPerecedero,
                EsFragil = producto.EsFragil,
                RequiereRefrigacion = producto.RequiereRefrigacion,
                ProductoPeligrosa = producto.ProductoPeligrosa,
                VidaUtil = producto.VidaUtil,
                TemperaturaAlmacenimiento = producto.TemperaturaAlmacenimiento,
                InstruccionesDeManejo = producto.InstruccionesDeManejo,
                TransporteId = producto.TransporteId,
                EmpaquetamientoId = producto.EmpaquetamientoId,
                NotasAdicionales = producto.NotasAdicionales,
                ProveedorId = producto.ProveedorId,
                TipoProductoId = producto.TipoProductoId,
                TipoProductoSelectList = new SelectList(tipoProductos, "Id", "Nombre"),
                ProveedorSelectList = new SelectList(proveedores, "Id", "RazonSocial"),
                MonedaSelectList = new SelectList(monedas, "Id", "SimboloMoneda"),
                CategoriaSelectList = new SelectList(categorias, "Id", "Nombre"),
                ClasificacionSelectList = new SelectList(clasificaciones, "Id", "Nombre"),
                TransporteSelectList = new SelectList(transportes, "Id", "Vehiculo"),
                EmpaquetamientoSelectList = new SelectList(empaquetamientos, "Id", "Nombre")
            };

            return View(viewModel);
           
        }

        // POST: ProductosController/Delete/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmacion(int id)
        {

            await _productoService.EliminarProductoAsync(id);
            TempData["success"] = "El producto ha sido eliminado con éxito";
            return RedirectToAction("Index");
        }

        // BUSQUEDA FUNCTION 

        public async Task<IActionResult> Buscar(string busqueda)
        {
            var productos = await _productoService.BusquedaProductosAsync(busqueda);
            return View(productos);
        }

    }
}
