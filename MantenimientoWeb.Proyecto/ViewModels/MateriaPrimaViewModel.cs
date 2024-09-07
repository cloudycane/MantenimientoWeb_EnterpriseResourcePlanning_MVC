using System.Web.Mvc;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class MateriaPrimaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int EmpresaId { get; set; } // Proveedor 
        public SelectList EmpresaProveedor { get; set; }
        public int TransporteId { get; set; } // FK
        public SelectList Transporte {  get; set; }
        public int EmpaquetamientoId { get; set; } // FK 
        public SelectList Empaquetamiento { get; set; }
        public int TipoMateriaPrimaId { get; set; } // FK
        public SelectList TipoMateriaPrima {  get; set; }
        public string NotasAdicionales { get; set; }
        public DateTime FechaCreacion {  get; set; }
    }
}
