using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ProyectoProgramadolll.Util;
using ProyectoProgramadolll.Entities.DTO;

namespace ProyectoProgramadolll.DAL
{
    public class DALVendedor : IDALVendedor
    {
        public Vendedor ActualizarVendedor(Vendedor vendedor)
        {
            Vendedor oVendedor = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ActualizarVendedor";
            cmd.CommandType = CommandType.StoredProcedure;
            double filas = 0;

            try
            {

                cmd.Parameters.AddWithValue("@CodigoVendedor", vendedor.CodigoVendedor);
                cmd.Parameters.AddWithValue("@IdRol", vendedor.IdRol);
                cmd.Parameters.AddWithValue("@Contrasegna", vendedor.Contrasegna);
                cmd.Parameters.AddWithValue("@IdTienda", vendedor.IdTienda);
                cmd.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", vendedor.Apellidos);
                cmd.Parameters.AddWithValue("@FechaNacimiento", vendedor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Fotografia", vendedor.Fotografia);
                cmd.Parameters.AddWithValue("@Estado", vendedor.Estado);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oVendedor = this.ObtenerVendedorPorId(vendedor.CodigoVendedor.ToString());

                return oVendedor;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }

        }

        public async Task<bool> EliminarVendedor(string codigoVendedor)
        {
            bool eliminado = false;
            double filas = 0d;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_EliminarVendedor";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoVendedor", codigoVendedor);

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
                throw;
            }
        }

        public Vendedor GuardarVendedor(Vendedor vendedor)
        {
            Vendedor oVendedor = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GuardarVendedor";
            cmd.CommandType = CommandType.StoredProcedure;
            double filas = 0;

            try
            {
                cmd.Parameters.AddWithValue("@IdVendedor", vendedor.IdVendedor);
                cmd.Parameters.AddWithValue("@CodigoVendedor", vendedor.CodigoVendedor);
                cmd.Parameters.AddWithValue("@IdRol", vendedor.IdRol);
                cmd.Parameters.AddWithValue("@Contrasegna", vendedor.Contrasegna);
                cmd.Parameters.AddWithValue("@IdTienda", vendedor.IdTienda);
                cmd.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", vendedor.Apellidos);
                cmd.Parameters.AddWithValue("@FechaNacimiento", vendedor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Fotografia", vendedor.Fotografia);
                cmd.Parameters.AddWithValue("@Estado", vendedor.Estado);



                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oVendedor = vendedor;


                return oVendedor;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public Vendedor Login(string codigoVendedor, string contrasegna)
        {
            StringBuilder conexion = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LoginVendedor";
            cmd.CommandType = CommandType.StoredProcedure;
            IDataReader reader = null;
            Vendedor vendedor = null;

            try
            {
                cmd.Parameters.AddWithValue("@codigoVendedor", codigoVendedor);
                cmd.Parameters.AddWithValue("@contrasegna", contrasegna);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(cmd);

                    while (reader.Read())
                    {
                        vendedor = new Vendedor();
                        vendedor.IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor"));
                        vendedor.CodigoVendedor = reader.GetString(reader.GetOrdinal("CodigoVendedor"));
                        vendedor.Contrasegna = reader.GetString(reader.GetOrdinal("Contrasegna"));
                        vendedor.IdRol = reader.GetInt32(reader.GetOrdinal("IdRol")).ToString();
                        vendedor.Estado = reader.GetInt32(reader.GetOrdinal("Estado")) == 1;
                    }
                }
                return vendedor;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public IEnumerable<VendedorDTO> ObtenerVendedores()
        {
            StringBuilder conexion = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            IDataReader reader = null;
            IList<VendedorDTO> lista = new List<VendedorDTO>();

            cmd.CommandText = "sp_ObtenerVendedores";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(cmd);

                    while (reader.Read())
                    {
                        VendedorDTO vendedorDto = new VendedorDTO();
                        vendedorDto.IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor"));
                        vendedorDto.CodigoVendedor = reader.GetString(reader.GetOrdinal("CodigoVendedor"));
                        vendedorDto.IdRol = reader.GetInt32(reader.GetOrdinal("IdRol"));
                        vendedorDto.RolDescripcion = reader.GetString(reader.GetOrdinal("RolDescripcion"));
                        vendedorDto.IdTienda = reader.GetInt32(reader.GetOrdinal("IdTienda"));
                        vendedorDto.NombreTienda = reader.GetString(reader.GetOrdinal("NombreTienda"));
                        vendedorDto.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                        vendedorDto.Apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));
                        vendedorDto.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        vendedorDto.Fotografia = reader["Fotografia"] == DBNull.Value ? null : (byte[])reader["Fotografia"];
                        vendedorDto.EstadoDescripcion = reader.GetString(reader.GetOrdinal("EstadoDescripcion"));
                        vendedorDto.Contrasegna = Cryptography.DecrypthAES(reader.GetString(reader.GetOrdinal("Contrasegna")));


                        lista.Add(vendedorDto);
                    }
                }
                return lista;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public Vendedor ObtenerVendedorPorId(string codigoVendedor)
        {
            DataSet ds = null;
            Vendedor oVendedor = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerVendedorPorId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoVendedor", codigoVendedor);

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(cmd, "T");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        oVendedor = new Vendedor();
                        oVendedor.IdVendedor = int.Parse(dr["IdVendedor"].ToString());
                        oVendedor.CodigoVendedor = dr["CodigoVendedor"].ToString();
                        oVendedor.IdRol = dr["IdRol"].ToString();
                        oVendedor.Contrasegna = dr["Contrasegna"].ToString();
                        oVendedor.IdTienda = int.Parse(dr["IdTienda"].ToString());
                        oVendedor.Nombre = dr["Nombre"].ToString();
                        oVendedor.Apellidos = dr["Apellidos"].ToString();
                        oVendedor.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oVendedor.Fotografia = dr["Fotografia"] == DBNull.Value ? null : (byte[])dr["Fotografia"];
                        //oVendedor.Estado = bool.Parse(dr["Estado"].ToString());
                        oVendedor.Estado = dr["Estado"] != DBNull.Value && (dr["Estado"].ToString() == "1" || dr["Estado"].ToString().ToLower() == "true");


                    }
                }
                return oVendedor;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;

            }
        }
    }

}