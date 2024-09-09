using MantenimientoWeb.Dominio.Entidades;
using MantenimientoWeb.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Infraestructura.Data
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmpresaModel>> ObtenerProveedoresAsync()
        {
            return await _context.Empresas.Where(e => e.TipoEmpresa.Nombre == "Proveedor").ToListAsync();
        }

        public async Task<IEnumerable<ProductoModel>> ObtenerListadoProductosAsync()
        {
            return await _context.Productos.Include(c => c.Categoria).Include(m => m.Moneda).Include(cl => cl.Clasificacion).Include(t => t.Transporte).Include(e => e.Empaquetamiento).Include(p => p.Proveedor).Include(t => t.TipoProducto).ToListAsync();
        }

        public async Task CreateAsync(ProductoModel producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductoModel> ObtenerIdAsync(int id)
        {
            return await _context.Set<ProductoModel>().FindAsync(id); 
        }

        public async Task<IEnumerable<ProductoModel>> ObtenerTodoAsync()
        {
            return await _context.Set<ProductoModel>().ToListAsync();
        }

        public async Task ActualizarAsync(ProductoModel producto)
        {
            var productoAnterior = await _context.Productos.FindAsync(producto.Id);
            if (productoAnterior != null)
            {
                // Update properties
                productoAnterior.Nombre = producto.Nombre;
                productoAnterior.Description = producto.Description;
                productoAnterior.FechaCreacion = producto.FechaCreacion;
                productoAnterior.FechaExpiracion = producto.FechaExpiracion;
                productoAnterior.MonedaId = producto.MonedaId;
                productoAnterior.PrecioOriginal = producto.PrecioOriginal;
                productoAnterior.LugarFabricacion = producto.LugarFabricacion;
                productoAnterior.CategoriaId = producto.CategoriaId;
                productoAnterior.ClasificacionId = producto.ClasificacionId;
                productoAnterior.CostoMantenimiento = producto.CostoMantenimiento;
                productoAnterior.NivelActual = producto.NivelActual;
                productoAnterior.PlazoEntrega = producto.PlazoEntrega;
                productoAnterior.DemandaAnual = producto.DemandaAnual;
                productoAnterior.StockActual = producto.StockActual;
                productoAnterior.ConsunmoDiarioPromedio = producto.ConsunmoDiarioPromedio;
                productoAnterior.LeadTime = producto.LeadTime;
                productoAnterior.StockSeguridad = producto.StockSeguridad;
                productoAnterior.StockMinimo = producto.StockMinimo;
                productoAnterior.EsPerecedero = producto.EsPerecedero;
                productoAnterior.EsFragil = producto.EsFragil;
                productoAnterior.RequiereRefrigacion = producto.RequiereRefrigacion;
                productoAnterior.ProductoPeligrosa = producto.ProductoPeligrosa;
                productoAnterior.VidaUtil = producto.VidaUtil;
                productoAnterior.TemperaturaAlmacenimiento = producto.TemperaturaAlmacenimiento;
                productoAnterior.InstruccionesDeManejo = producto.InstruccionesDeManejo;
                productoAnterior.TransporteId = producto.TransporteId;
                productoAnterior.EmpaquetamientoId = producto.EmpaquetamientoId;
                productoAnterior.NotasAdicionales = producto.NotasAdicionales;
                productoAnterior.ProveedorId = producto.ProveedorId;
                productoAnterior.TipoProductoId = producto.TipoProductoId;

                await _context.SaveChangesAsync();
            }
        }

        public async Task EliminarAsync(int id)
        {
            var producto = await ObtenerIdAsync(id);
            if (producto != null)
            {
                _context.Set<ProductoModel>().Remove(producto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EliminarInventarioPorProductoIdAsync(int productoId)
        {
            var inventarios = await _context.Inventario.Where(i => i.ProductoId == productoId).ToListAsync();
            _context.Inventario.RemoveRange(inventarios);
            await _context.SaveChangesAsync();
        }

    }
}
