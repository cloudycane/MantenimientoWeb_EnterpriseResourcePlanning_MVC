using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    public class ListadoMonedasViewModel
    {
        // LISTADO DE SIMBOLO DE MONEDAM IMPORTANTE PARA EL SELECT LIST
        public IEnumerable<MonedaProductoModel> Monedas {  get; set; }
    }
}
