using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Entidades
{
    public class InventarioModel
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public ProductoModel Producto { get; set; }
        public int UnidadesDeCompraEnAño { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCompra {  get; set; }
        public double CostoPercentual { get; set; }
        public double CostoTotalMantenimiento { get; set; }
        public double CostoPedido { get; set; }
        public int EstadoProductoId { get; set; }
        public EstadoProductoModel EstadoProducto { get; set; }

    }
}
