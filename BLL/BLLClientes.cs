using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoProgramadolll.Util;
using ProyectoProgramadolll.DAL;
using ProyectoProgramadolll.Entities.DTO;

namespace ProyectoProgramadolll.BLL
{
    public class BLLClientes : IBLLClientes
    {
        public Task<bool> EliminarCliente(string identificacion)
        {
            IDALClientes clienteDAL = new DALClientes();
            return clienteDAL.EliminarCliente(identificacion);
        }

        public ClienteDTO GuardarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos)
        {

            IDALClientes clienteDAL = new DALClientes();
            string mensaje = "";
            ClienteDTO oCliente = null;
            ClienteDTO clientePorId = clienteDAL.ObtenerClientePorId(cliente.IdCliente.ToString());

            if (!ValidarCliente(cliente, ref mensaje))
            {
                Log.LogException(new Exception(mensaje));
                return null;
            }
            cliente.Contrasegna = Cryptography.EncrypthAES(cliente.Contrasegna);

            if (clientePorId == null)
                oCliente = clienteDAL.GuardarCliente(cliente, direccion, telefonos);
            else
                oCliente = clienteDAL.ActualizarCliente(cliente, direccion, telefonos);
            return oCliente;
        }
        public bool ValidarCliente(ClienteDTO cliente, ref string mensaje)
        {

            if (cliente.Contrasegna.Length < 8)
            {
                mensaje = "La contraseña debe tener al menos 8 caracteres";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cliente.Identificacion))
            {
                mensaje = "Debe ingresar una identificación.";
                return false;
            }
            else if (cliente.IdTipoIdentificacion <= 0)
            {
                mensaje = "Debe seleccionar un tipo de identificación válido.";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                mensaje = "Debe ingresar un nombre.";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cliente.CorreoElectronico))
            {
                mensaje = "Debe ingresar un correo electrónico.";
                return false;
            }
            else if (!cliente.CorreoElectronico.Contains("@"))
            {
                mensaje = "Debe ingresar un correo electrónico válido.";
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<ClienteDTO> ObtenerClientes()
        {
            IDALClientes dalClientes = new DALClientes();
            return dalClientes.ObtenerClientes();
        }

        public bool ValidarCliente(string idCliente)
        {
            IDALClientes clienteDAL = new DALClientes();
            return clienteDAL.ValidarCliente(idCliente);
        }
    }
}
