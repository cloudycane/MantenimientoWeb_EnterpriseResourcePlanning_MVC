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
    public class InventarioRepository : IInventarioRepository
    {
        private readonly ApplicationDbContext _context;

        public InventarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InventarioModel>> ObtenerListadoInventarioAsync()
        {
            return await _context.Inventario.Include(p => p.Producto).Include(e => e.EstadoProducto).Include(m => m.Producto.Moneda).ToListAsync();
        }

        public async Task CreateAsync(InventarioModel inventario)
        {
            await _context.Inventario.AddAsync(inventario);
            await _context.SaveChangesAsync();
        }

        public async Task<InventarioModel> ObtenerIdAsync(int id)
        {
            return await _context.Set<InventarioModel>().FindAsync(id);
        }

        public async Task<IEnumerable<InventarioModel>> ObtenerTodoAsync()
        {
            return await _context.Set<InventarioModel>().ToListAsync();
        }

        public async Task ActualizarAsync(InventarioModel inventario)
        {
            var inventarioAnterior = await _context.Inventario.FindAsync(inventario.Id);

            if(inventarioAnterior != null)
            {
                inventarioAnterior.ProductoId = inventario.ProductoId;
                inventarioAnterior.UnidadesDeCompraEnAño = inventario.UnidadesDeCompraEnAño;
                inventarioAnterior.Cantidad = inventario.Cantidad;
                inventarioAnterior.PrecioCompra = inventario.PrecioCompra;
                inventarioAnterior.CostoPercentual = inventario.CostoPercentual;
                inventarioAnterior.CostoTotalMantenimiento = inventario.CostoTotalMantenimiento;
                inventarioAnterior.CostoPedido = inventario.CostoPedido;
                inventarioAnterior.EstadoProductoId = inventario.EstadoProductoId;
            
                await _context.SaveChangesAsync();  
            
            }
        }

        public async Task EliminarAsync(int id)
        {
            var inventario = await ObtenerIdAsync(id);
            if (inventario != null)
            {
                _context.Set<InventarioModel>().Remove(inventario);
                await _context.SaveChangesAsync();
            }
        }

        

    }
}
