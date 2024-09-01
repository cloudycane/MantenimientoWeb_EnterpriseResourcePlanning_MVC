using Microsoft.AspNetCore.Mvc.Rendering;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class PaisRegistrarViewModel
    {
        public SelectList Paises { get; set; }
        public int PaisId { get; set; }
    }
}
