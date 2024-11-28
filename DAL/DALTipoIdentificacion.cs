using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ProyectoProgramadolll.DAL
{
    public class DALTipoIdentificacion : IDALTipoIdentificacion
    {
        public List<TipoIdentificacion> ObtenerTipoIdentificacion()
        {
            StringBuilder conexion = new StringBuilder();
            IDataReader reader = null;
            List<TipoIdentificacion> tipos = new List<TipoIdentificacion>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerTipoIdentificacion";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(cmd);
                    while (reader.Read())
                    {
                        TipoIdentificacion tipo = new TipoIdentificacion();
                        tipo.IdTipoIdentificacion = Convert.ToInt32(reader["IdTipoIdentificacion"]);
                        tipo.Descripcion = reader["Descripcion"].ToString();
                        tipos.Add(tipo);
                    }
                }
                return tipos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los roles", ex);
            }
        }
    }
}
