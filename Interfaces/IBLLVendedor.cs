using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLVendedor
    {
        Vendedor Login(string codigoVendedor, string contrasegna);
        Vendedor GuardarVendedor(Vendedor vendedor);
        IEnumerable<VendedorDTO> ObtenerVendedores();
        Task<bool> EliminarVendedor(string codigoVendedor);

    }
}
