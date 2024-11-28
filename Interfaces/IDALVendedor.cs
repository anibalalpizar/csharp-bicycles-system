using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALVendedor
    {
        VendedorClienteDTO Login(string codigoVendedor, string contrasegna);
        Vendedor GuardarVendedor(Vendedor vendedor);
        IEnumerable<VendedorDTO> ObtenerVendedores();
        Vendedor ObtenerVendedorPorId(string codigoVendedor);
        Vendedor ActualizarVendedor(Vendedor vendedor);
        Task<bool> EliminarVendedor(string codigoVendedor);

    }
}
