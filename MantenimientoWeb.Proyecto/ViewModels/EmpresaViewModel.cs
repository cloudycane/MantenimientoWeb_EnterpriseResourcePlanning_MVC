using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    // PARA MANEJAR EL BUSINESS MODEL VALIDATIONS DE EMPRESA
    public class EmpresaViewModel
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Empresa ID/ CIF / NIF")]
        [StringLength(10, ErrorMessage = "El campo {0} tiene una longitud de {1} caracteres.")]
        public string CIF { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Razón Social")]
        [StringLength(100, ErrorMessage = "El campo {0} tiene {1} longitud de caracteres.")]
        public string RazonSocial { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress(ErrorMessage = "Este campo requiere un correo electrónico válido.")]
        public string CorreoElectronico { get; set; }


        [Display(Name = "País de Residencia")]
        public int PaisId { get; set; }
        
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Dirección")]
        [StringLength(250, ErrorMessage = "El campo {0} tiene {1} longitud de caracteres.")]
        public string Direccion {  get; set; }

        [Display(Name = "Tipo de Empresa")]
        public int TipoEmpresaId { get; set; }
        
        public SelectList PaisesSelectList { get; set; }

        public SelectList TipoEmpresaSelectList { get; set; }

    }
}
