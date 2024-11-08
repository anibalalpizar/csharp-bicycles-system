using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.DAL
{
    public class DALVendedor : IDALVendedor
    {
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
                throw new Exception("Error al guardar el vendedor", ex);
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
                    }
                }
                return vendedor;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al iniciar sesión", ex);
            }
        }

        public IEnumerable<Vendedor> ObtenerVendedores()
        {
            StringBuilder conexion = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            IDataReader reader = null;
            IList<Vendedor> lista = new List<Vendedor>();

            cmd.CommandText = "sp_ObtenerVendedores";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(cmd);

                    while (reader.Read())
                    {
                        Vendedor vendedor = new Vendedor();
                        vendedor.IdVendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor"));
                        vendedor.CodigoVendedor = reader.GetString(reader.GetOrdinal("CodigoVendedor"));
                        vendedor.RolDescripcion = reader.GetString(reader.GetOrdinal("RolDescripcion"));
                        vendedor.NombreTienda = reader.GetString(reader.GetOrdinal("NombreTienda"));
                        vendedor.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                        vendedor.Apellidos = reader.GetString(reader.GetOrdinal("Apellidos"));
                        vendedor.FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        vendedor.Fotografia = reader["Fotografia"] == DBNull.Value ? null : (byte[])reader["Fotografia"];
                        vendedor.EstadoDescripcion = reader.GetString(reader.GetOrdinal("EstadoDescripcion"));

                        lista.Add(vendedor);
                    }
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los vendedores", ex);
            }
        }
    }
}