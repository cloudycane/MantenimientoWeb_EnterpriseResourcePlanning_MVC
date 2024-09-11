using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ListadoInventarioModel
    {
        // PARA EL LISTADO DE INVENTARIO, IMPORTANTE PARA EL SELECTLIST
        public IEnumerable<InventarioModel> Inventarios { get; set; }
        public int PaginaActual { get; set; }
        public int PaginasTotal { get; set; }
    }
}
