using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ListadoInventarioModel
    {
        public IEnumerable<InventarioModel> Inventarios { get; set; }
        public int PaginaActual { get; set; }
        public int PaginasTotal { get; set; }
    }
}
