using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ListadoProductoModel
    {
        // LISTADO DE PRODUCTOS Y PAGINACIÓN
        public IEnumerable<ProductoModel> Productos { get; set; }

        // Paginacion 

        public int PaginaActual { get; set; }
        public int PaginasTotal { get; set; }
    }
}
