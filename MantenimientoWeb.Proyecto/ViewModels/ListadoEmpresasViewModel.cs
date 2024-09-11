using MantenimientoWeb.Dominio.Entidades;

namespace MantenimientoWeb.Proyecto.ViewModels
{
    // PARA EL SELECT LIST DE EMPRESA Y LA PAGINACIÓN
    public class ListadoEmpresasViewModel
    {
        public IEnumerable<EmpresaModel> Empresas { get; set; }

        // Para la paginacion manual 

        public int PaginaActual { get; set; }
        public int PaginasTotal { get; set; }



    }
}
