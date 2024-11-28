using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace ProyectoProgramadolll.DAL
{
    public class DALRol : IDALRol
    {
        public List<Rol> ObtenerRoles()
        {
            StringBuilder conexion = new StringBuilder();
            IDataReader reader = null;
            List<Rol> roles = new List<Rol>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerRoles";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(cmd);
                    while (reader.Read())
                    {
                        Rol rol = new Rol();
                        rol.IdRol = Convert.ToInt32(reader["IdRol"]);
                        rol.DescripcionRol = reader["Descripcion"].ToString();
                        roles.Add(rol);
                    }
                }
                return roles;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los roles", ex);
            }
        }
    }
}
