using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALClientes
    {
        ClienteDTO GuardarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos);
        ClienteDTO ObtenerClientePorId(string idCliente);

        ClienteDTO ActualizarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos);

        Task<bool> EliminarCliente(string identificacion);
        List<ClienteDTO> ObtenerClientes();
    }
}
