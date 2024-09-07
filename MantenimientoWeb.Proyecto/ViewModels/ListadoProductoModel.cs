using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ListadoProductoModel
    {
        public IEnumerable<ProductoModel> Productos { get; set; }

        // Paginacion 

        public int PaginaActual { get; set; }
        public int PaginasTotal { get; set; }
    }
}
