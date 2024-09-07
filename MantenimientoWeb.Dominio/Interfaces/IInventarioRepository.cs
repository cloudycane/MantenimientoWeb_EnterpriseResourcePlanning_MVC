﻿using MantenimientoWeb.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Dominio.Interfaces
{
    public interface IInventarioRepository
    {
        Task CreateAsync(InventarioModel inventario);
        Task<IEnumerable<InventarioModel>> ObtenerListadoInventarioAsync();
    }
}