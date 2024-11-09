using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALVendedor
    {
        Vendedor Login(string codigoVendedor, string contrasegna);
        Vendedor GuardarVendedor(Vendedor vendedor);
        IEnumerable<VendedorDTO> ObtenerVendedores();
        Vendedor ObtenerVendedorPorId(string codigoVendedor);
        Vendedor ActualizarVendedor(Vendedor vendedor);
        Task<bool> EliminarVendedor(string codigoVendedor);

    }
}
