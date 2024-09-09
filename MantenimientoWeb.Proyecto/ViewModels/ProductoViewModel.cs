using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ProductoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Nombre del producto")]
        [StringLength(100, ErrorMessage = "El campo {0} tiene un máximo de caracteres de {1}")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(500, ErrorMessage = "El campo {0} tiene un máximo de caracteres de {1}")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Fecha de Creación del Producto")]
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaExpiracion { get; set; } // Lo dejaria como nullable porque algunos materiales no se saben su caducacion...
        public int MonedaId { get; set; } //FK 
        public SelectList MonedaSelectList { get; set; } // MVC rendering

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public double PrecioOriginal { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(500, ErrorMessage = "El campo {0} tiene una longitud de caracteres de {1}")]
        public string LugarFabricacion { get; set; }

        public int CategoriaId { get; set; } // FK
        public SelectList CategoriaSelectList { get; set; } // MVC rendering
        public int ClasificacionId { get; set; } // FK 
        public SelectList ClasificacionSelectList { get; set; } // MVC rendering

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public double CostoMantenimiento { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int NivelActual { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int PlazoEntrega { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int DemandaAnual {  get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int StockActual { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int ConsumoDiarioPromedio { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int LeadTime { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int StockSeguridad { get; set; }
        public int StockMinimo // Se calcula pero lo omitimos en el form 
        {
            get
            {
                return CalcularStockMinimo();
            }
        }

        // He aprendido que el modelo EOQ o Economic Order Quantity es un modelo para determinar 
        // la cantidad óptima de unidades que una empresa debe pedir para minimizar los costos totales asociados con la compra, almacen, y inventario. 
        public double EOQ
        {
            get
            {
                return CalcularEOQ();
            }
        }

        // He aprendido que una sugerencia tipo JIT o Just In Time es una sugerencia estratégica de 
        // gestión de inventario y producción que tiene objetivo de minimizar los niveles de inventario y reducir los tiempos de producción. 
        public int SugerenciaJIT
        {
            get
            {
                return CalcularSugerenciaJIT();
            }
        }

        // He aprendido que el SugeridodeCompras es una herramienta para tener una idea de las cantidades de productos o materiales que se deben ordenar en el próximo pedido. 
        public int SugeridoCompras
        {
            get
            {
                return CalcularSugeridoCompras();
            }
        }
        // PROVEEDOR 

        public int ProveedorId { get; set; }
        public SelectList ProveedorSelectList { get; set; }
        
        public int TipoProductoId { get; set; }
        public SelectList TipoProductoSelectList { get; set; }


        // ESPECIFICACIONES DEL PRODUCTO 

        public bool EsPerecedero { get; set; }
        public bool EsFragil {  get; set; }
        public bool RequiereRefrigacion { get; set; }
        public bool ProductoPeligrosa { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Range(0, int.MaxValue, ErrorMessage = "El campo {0} no admite valores negativos")]
        public int VidaUtil {  get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public int TemperaturaAlmacenimiento { get; set; } // En Celsius
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(1000, ErrorMessage = "El campo {0} tiene un máximo de caracteres de {1}")]
        public string InstruccionesDeManejo { get; set; }
        public int TransporteId { get; set; } // FK Transporte
        public SelectList TransporteSelectList { get; set; }
        public int EmpaquetamientoId { get; set; } // FK Empaque
        public SelectList EmpaquetamientoSelectList { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(1000, ErrorMessage = "El campo {0} tiene un máximo de caracteres de {1}")]
        public string NotasAdicionales { get; set; }

       // PRIVATE FUNCTIONS 

        private double CalcularEOQ()
        {
            if (CostoMantenimiento == 0) return 0; 
            return Math.Sqrt((2 * DemandaAnual * PrecioOriginal) / CostoMantenimiento);
        }

        private int CalcularSugerenciaJIT()
        {
            int demandaDurantePlazoEntrega = (int)(DemandaAnual / 365 * PlazoEntrega);
            int cantidadSugerida = demandaDurantePlazoEntrega - NivelActual;
            return cantidadSugerida > 0 ? cantidadSugerida : 0; 
        }

        private int CalcularSugeridoCompras()
        {
            if (NivelActual <= EOQ)
            {
                return (int)EOQ; 
            }

            return SugerenciaJIT > 0 ? SugerenciaJIT : (int)EOQ; 
        }

        private int CalcularStockMinimo()
        {
            int stockMinimo = ConsumoDiarioPromedio * LeadTime + StockSeguridad;
            return stockMinimo;
        }
    }
}
