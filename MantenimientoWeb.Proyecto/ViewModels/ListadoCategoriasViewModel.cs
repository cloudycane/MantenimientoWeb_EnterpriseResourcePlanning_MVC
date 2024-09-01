using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ListadoCategoriasViewModel
    {
        public IEnumerable<CategoriaProductoModel> Categorias { get; set; }
    }
}
