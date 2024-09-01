using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Aplicacion.DTOs
{
    public class PaisDTO
    {
        public int Id{ get; set; }
        [Required]
        public string? Nombre { get; set; }
    }
}
