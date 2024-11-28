using Newtonsoft.Json;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using ProyectoProgramadolll.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.DAL
{
    public class DALClientes : IDALClientes
    {
        public ClienteDTO ActualizarCliente( ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos)
        {
            ClienteDTO oCliente = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ActualizarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            double filas = 0;
            
            string jsonTelefonos = JsonConvert.SerializeObject(telefonos.Select(t => t.NumeroTelefonico).ToList());

            try
            {
                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                cmd.Parameters.AddWithValue("@idTipoIdentificacion", cliente.IdTipoIdentificacion);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@contrasegna", cliente.Contrasegna);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);

                cmd.Parameters.AddWithValue("@idProvincia", direccion.IdProvincia);
                cmd.Parameters.AddWithValue("@descripcionProvincia", direccion.DescripcionProvincia);
                cmd.Parameters.AddWithValue("@idCanton", direccion.IdCanton);
                cmd.Parameters.AddWithValue("@descripcionCanton", direccion.DescripcionCanton);
                cmd.Parameters.AddWithValue("@idDistrito", direccion.IdDistrito);
                cmd.Parameters.AddWithValue("@descripcionDistrito", direccion.DescripcionDistrito);

                cmd.Parameters.AddWithValue("@telefonos", jsonTelefonos);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                {
                    oCliente = this.ObtenerClientePorId(cliente.IdCliente.ToString());
                }

                return oCliente;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public async Task<bool> EliminarCliente(string identificacion)
        {
            bool eliminado = false;
            double filas = 0d;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_EliminarCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@identificacion", identificacion);

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = await db.ExecuteNonQueryAsync(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    eliminado = true;
                return eliminado;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw new Exception("Verifique sus biciletas");

            }
        }

        public ClienteDTO GuardarCliente(ClienteDTO cliente, Direccion direccion, List<Telefono> telefonos)
        {
            ClienteDTO oCliente = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GuardarCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            string jsonTelefonos = JsonConvert.SerializeObject(telefonos.Select(t => t.NumeroTelefonico).ToList());

            try
            {
                
                cmd.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                cmd.Parameters.AddWithValue("@idTipoIdentificacion", cliente.IdTipoIdentificacion);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@contrasegna", cliente.Contrasegna);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);

                cmd.Parameters.AddWithValue("@idProvincia", direccion.IdProvincia);
                cmd.Parameters.AddWithValue("@descripcionProvincia", direccion.DescripcionProvincia);
                cmd.Parameters.AddWithValue("@idCanton", direccion.IdCanton);
                cmd.Parameters.AddWithValue("@descripcionCanton", direccion.DescripcionCanton);
                cmd.Parameters.AddWithValue("@idDistrito", direccion.IdDistrito);
                cmd.Parameters.AddWithValue("@descripcionDistrito", direccion.DescripcionDistrito);

               
                cmd.Parameters.AddWithValue("@telefonos", jsonTelefonos);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    
                    int filasAfectadas = (int)db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);

                    if (filasAfectadas > 0)
                    {
                        oCliente = cliente;
                    }
                    
                }

                return oCliente;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                return null;
            }
        }

  

        public ClienteDTO ObtenerClientePorId(string idCliente)
        {
            DataSet dsCliente = null;
            ClienteDTO oCliente = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerClientePorId";  
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCliente", idCliente);

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    dsCliente = db.ExecuteReader(cmd, "T");
                }

                if (dsCliente.Tables[0].Rows.Count > 0)
                {
                    oCliente = new ClienteDTO();
                    DataRow row = dsCliente.Tables[0].Rows[0];

                    oCliente.IdCliente = Convert.ToInt32(row["IdCliente"]);
                    oCliente.Identificacion = row["Identificacion"].ToString();
                    oCliente.IdTipoIdentificacion = Convert.ToInt32(row["IdTipoIdentificacion"]);
                    oCliente.Nombre = row["Nombre"].ToString();
                    oCliente.Sexo = Convert.ToBoolean(row["Sexo"]);
                    oCliente.CorreoElectronico = row["CorreoElectronico"].ToString();
                    oCliente.IdDireccion = Convert.ToInt32(row["IdDireccion"]);
                    oCliente.Estado = Convert.ToBoolean(row["Estado"]);
                    

                    if (row["descripcionProvincia"] != DBNull.Value)
                    {
                        oCliente.Direccion = new Direccion
                        {
                            DescripcionProvincia = row["descripcionProvincia"].ToString(),
                            DescripcionCanton = row["descripcionCanton"].ToString(),
                            DescripcionDistrito = row["descripcionDistrito"].ToString()
                        };
                    }

                    
                    oCliente.ListaTelefonos = new List<Telefono>();

                    foreach (DataRow telefonoRow in dsCliente.Tables[0].Rows)
                    {
                        var telefono = new Telefono
                        {
                            IdTelefono = Convert.ToInt32(telefonoRow["IdTelefono"]),
                            NumeroTelefonico = telefonoRow["numeroTelefonico"].ToString()
                        };
                        oCliente.ListaTelefonos.Add(telefono);
                    }
                }

                return oCliente;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }


        public List<ClienteDTO> ObtenerClientes()
        {
            IDataReader reader = null;
            List<ClienteDTO> listaClientes = new List<ClienteDTO>();
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
                        ClienteDTO clienteDto = new ClienteDTO();
                        clienteDto.IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente"));  
                        clienteDto.Identificacion = reader.GetString(reader.GetOrdinal("Identificacion"));
                        clienteDto.IdTipoIdentificacion = reader.GetInt32(reader.GetOrdinal("IdTipoIdentificacion"));
                        clienteDto.TipoIdentificacionDescripcion = reader.GetString(reader.GetOrdinal("TipoIdentificacionDescripcion")); 
                        clienteDto.Nombre = reader.GetString(reader.GetOrdinal("Nombre")); 
                        clienteDto.Genero = reader.GetString(reader.GetOrdinal("Genero"));
                        clienteDto.CorreoElectronico = reader.GetString(reader.GetOrdinal("CorreoElectronico"));
                        clienteDto.EstadoDescripcion = reader.GetString(reader.GetOrdinal("EstadoDescripcion"));
                        clienteDto.Contrasegna = Cryptography.DecrypthAES(reader.GetString(reader.GetOrdinal("Contrasegna")));

                        clienteDto.IdDireccion = reader.GetInt32(reader.GetOrdinal("IdDireccion"));  
                        clienteDto.DireccionCompleta = reader.GetString(reader.GetOrdinal("DireccionCompleta")); 
                        clienteDto.Telefonos = reader.GetString(reader.GetOrdinal("Telefonos"));
                        clienteDto.ListaTelefonos = new List<Telefono>();

                        listaClientes.Add(clienteDto);

                        if (!string.IsNullOrEmpty(clienteDto.Telefonos))
                        {
                            var telefonos = clienteDto.Telefonos.Split(',').Select(t => new Telefono { NumeroTelefonico = t.Trim() }).ToList();
                            clienteDto.ListaTelefonos.AddRange(telefonos);
                        }

                    }             
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }


        public bool ValidarCliente(string idCliente)
        {
            IDataReader reader = null;
            bool eliminado = false;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ValidarClienteRelaciones";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCliente", idCliente);

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader =  db.ExecuteReader(cmd);

                    while (reader.Read())
                    {

                        eliminado = reader.GetBoolean(reader.GetOrdinal("existe"));

                    }
                }
                return eliminado;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public async Task<List<ClienteDTO>> ObtenerClientesConBicicletas()
        {
            IDataReader reader = null;
            List<ClienteDTO> listaClientes = new List<ClienteDTO>();
            SqlCommand command = new SqlCommand();
            command.CommandText = "sp_ObtenerClientesConBicicletas";
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = await db.ExecuteReaderAsync(command);

                    while (reader.Read())
                    {
                        ClienteDTO clienteDto = new ClienteDTO();
                        clienteDto.IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente"));
                        clienteDto.Identificacion = reader.GetString(reader.GetOrdinal("Identificacion"));
                        clienteDto.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));

                        listaClientes.Add(clienteDto);

                    }
                }
                return listaClientes;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }
    }
}

