using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class CompraViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(100)]
        public string NombreCliente { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(100)]
        public string ApellidosCliente { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(15)]
        public string Identificacion { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [EmailAddress(ErrorMessage = "Requiere un correo electrónico válido.")]
        public string CorreoElectronico { get; set; }
        
        public int PaisId { get; set; }
        public SelectList PaisSelectList { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(100)]
        public string Direccion {  get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public DateTime FechaCompra { get; set; }
        public int ProductoId { get; set; }
        public SelectList ProductoSelectList { get; set; }
        public int EstadoProductoId { get; set; }
        public SelectList EstadoProductoSelectList { get; set; }
        public int EmpresaId { get; set; }
        public SelectList EmpresaSelectList { get; set; }
        public int InventarioId { get; set; }
        public SelectList InventarioSelectList { get; set; }
    }
}
