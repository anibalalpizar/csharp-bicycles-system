using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.DAL
{
    public class DALClientes : IDALClientes
    {
        public List<Cliente> ObtenerClientes()
        {
            IDataReader reader = null;
            List<Cliente> listaClientes = new List<Cliente>();
            SqlCommand command = new SqlCommand();
            command.CommandText = "sp_ObtenerClientes";
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                        cliente.Identificacion = reader["Identificacion"].ToString();
                        cliente.IdTipoIdentificacion = Convert.ToInt32(reader["IdTipoIdentificacion"]);
                        cliente.Nombre = reader["Nombre"].ToString();
                        cliente.Apellidos = reader["Apellidos"].ToString();
                        cliente.Sexo = Convert.ToInt32(reader["Sexo"]);
                        cliente.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        cliente.IdDireccion = Convert.ToInt32(reader["IdDireccion"]);

                        listaClientes.Add(cliente);
                    }
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
