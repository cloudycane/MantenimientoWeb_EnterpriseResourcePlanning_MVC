using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Entidades
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int MonedaId { get; set; }
        public MonedaProductoModel Moneda {  get; set; }
        public double PrecioOriginal { get; set; }
        public string LugarFabricacion { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaProductoModel Categoria { get; set; }
        public int ClasificacionId {  get; set; }
        public ClasificacionProductoModel Clasificacion {  get; set; } 
        public double CostoMantenimiento { get; set; }
        public int NivelActual { get; set; }
        public int PlazoEntrega { get; set; }
        public int DemandaAnual {  get; set; }
        public int StockActual { get; set; }
        public int ConsunmoDiarioPromedio { get; set; }
        public int LeadTime { get; set; }
        public int StockSeguridad { get; set; }
        public int StockMinimo { get; set; }
        public bool EsPerecedero { get; set; }
        public bool EsFragil { get; set; }
        public bool RequiereRefrigacion { get; set; }
        public bool ProductoPeligrosa { get; set; }
        public int VidaUtil { get; set; }
        public int TemperaturaAlmacenimiento { get; set; }
        public string InstruccionesDeManejo { get; set; }
        public int TransporteId { get; set; }
        public TransporteModel Transporte { get; set; }
        public int EmpaquetamientoId { get; set; }
        // public EmpaquetamientoModel Empaquetamiento 
        public string NotasAdicionales {  get; set; }

    }
}
