﻿using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLVendedor
    {
        VendedorClienteDTO Login(string codigoVendedor, string contrasegna);
        Vendedor GuardarVendedor(Vendedor vendedor);
        IEnumerable<VendedorDTO> ObtenerVendedores();
        Task<bool> EliminarVendedor(string codigoVendedor);

    }
}
