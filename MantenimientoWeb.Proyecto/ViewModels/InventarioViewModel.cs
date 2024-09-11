using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace MantenimientoWeb.Proyecto.ViewModels
{
    // PARA MANEJAR EL BUSINESS MODEL VALIDATIONS DE INVENTARIO
    public class InventarioViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ProductoId { get; set; } // Productos terminados
        
        public SelectList ProductoSelectList { get; set; }

        [Required]
        [Display(Name = "Unidades de Compra en Año" )]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} no admite valores 0 y negativos.")]
        public int UnidadesDeCompraEnAño {  get; set; }

        [Required]
        [Display(Name = "Cantidad de Producto")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} no admite valores 0 y negativos.")]
        public int Cantidad {  get; set; }

        [Required]
        [Display(Name = "Precio de Compra")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} no admite valores 0 y negativos.")]
        public double PrecioCompra {  get; set; }

        // CALCULOS INVENTARIOS: PRECIO MANTENIMIENTO
        
        public double CostoPercentual {
            get 
            {  
                return CalcularCostoPercentual(); 
            }
                }
        private double CalcularCostoPercentual()
        {
            double CostoPercentual = (UnidadesDeCompraEnAño * Cantidad) / 2;
            return CostoPercentual;
        }
        public double CostoTotalMantenimiento
        {
            get
            {
                return CalcularCostoTotalMantenimiento();
            }
        }
        private double CalcularCostoTotalMantenimiento()
        {
            double CostoTotalMantenimiento = CostoPercentual * PrecioCompra * ((UnidadesDeCompraEnAño / (double)Cantidad) / 2);
            return CostoTotalMantenimiento;
        }
        // CALCULOS INVENTARIOS : COSTOS DE PEDIDO O DE PREPARACIÓN 

        public double CostoPedido
        {
            get
            {
                return CalcularCostoPedido();
            }
        }
        
        private double CalcularCostoPedido()
        {
            double CostoPedido = PrecioCompra * UnidadesDeCompraEnAño;
            return CostoPedido;
        }

        // SELECT LIST : ESTADO PRODUCTO
        [Required]
        public int EstadoProductoId { get; set; }
        public SelectList EstadoProductoSelectList { get; set; }
        

    }
}
