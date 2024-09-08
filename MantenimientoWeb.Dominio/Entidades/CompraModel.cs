using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Entidades
{
    public class CompraModel
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidosCliente { get; set; }
        public string Identificacion { get; set; }
        public string CorreoElectronico { get; set; }
        public int PaisId { get; set; }
        public PaisModel Pais { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaCompra { get; set; }
        public int ProductoId { get; set; }
        public ProductoModel Producto { get; set; }
        public int EmpresaId { get; set; }
        public EmpresaModel Empresa { get; set; }
        public int InventarioId { get; set; }
        public InventarioModel Inventario { get; set; }

    }
}
