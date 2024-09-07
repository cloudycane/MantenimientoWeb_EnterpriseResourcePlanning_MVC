using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ListadoInventarioModel
    {
        public IEnumerable<InventarioModel> Inventarios { get; set; }
    }
}
