﻿using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALClientes
    {
        ClienteDTO GuardarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos);
        ClienteDTO ObtenerClientePorId(string idCliente);

        ClienteDTO ActualizarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos);

        Task<bool> EliminarCliente(string identificacion);

        bool ValidarCliente(string idCliente);
        List<ClienteDTO> ObtenerClientes();
        Task<List<ClienteDTO>> ObtenerClientesConBicicletas();
    }
}
