using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    // LISTADO DE CATEGORIA IMPORTANTE PARA SELECTLIST
    public class ListadoCategoriasViewModel
    {
        public IEnumerable<CategoriaProductoModel> Categorias { get; set; }
    }
}
