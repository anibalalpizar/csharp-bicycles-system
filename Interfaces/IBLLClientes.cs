using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLClientes
    {
        List<ClienteDTO> ObtenerClientes();
        ClienteDTO GuardarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos);
        Task<bool> EliminarCliente(string identificacion);

        bool ValidarCliente(string idCliente);

        Task<List<ClienteDTO>> ObtenerClientesConBicicletas();
    }
}
