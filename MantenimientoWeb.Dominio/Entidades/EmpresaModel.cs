
using System.Web.Mvc;

namespace MantenimientoWeb.Dominio.Entidades
{
    public class EmpresaModel
    {
        public int Id { get; set; }
        public string CIF { get; set; }
        public string RazonSocial { get; set; }
        public string CorreoElectronico { get; set; }
        public int PaisId { get; set; }
        public string Direccion { get; set; }
        public int? TipoEmpresaId { get; set; }
        public PaisModel Pais { get; set; }
        public TipoEmpresaModel TipoEmpresa { get; set; }
    
    }
}
