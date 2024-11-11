using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLClientes
    {
        List<ClienteDTO> ObtenerClientes();
        ClienteDTO GuardarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos);
        Task<bool> EliminarCliente(string identificacion);
    }
}
