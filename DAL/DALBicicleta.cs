using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using ProyectoProgramadolll.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.DAL
{
    public class DALBicicleta : IDALBicicleta
    {
        public async Task<Bicicleta> ActualizarBicicleta(Bicicleta bicicleta)
        {
            Bicicleta oBicicleta = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ActualizarBicicleta";
            cmd.CommandType = CommandType.StoredProcedure;
            double filas = 0;

            try
            {
                cmd.Parameters.Add(new SqlParameter("@numeroSerie", bicicleta.NumeroSerie));
                cmd.Parameters.Add(new SqlParameter("@idCliente", bicicleta.IdCliente));
                cmd.Parameters.Add(new SqlParameter("@marca", bicicleta.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", bicicleta.Modelo));
                cmd.Parameters.Add(new SqlParameter("@color", bicicleta.Color));

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = await db.ExecuteNonQueryAsync(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oBicicleta = this.ObtenerBicicletaPorSerie(bicicleta.NumeroSerie);

                return oBicicleta;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;

            }

        }
        public async Task<bool> EliminarBiicleta(string idBicicleta)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_EliminarBicicleta";
            cmd.CommandType = CommandType.StoredProcedure;

            double filas = 0;

            try
            {
                cmd.Parameters.Add(new SqlParameter("@idBicicleta", idBicicleta));

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = await db.ExecuteNonQueryAsync(cmd, IsolationLevel.ReadCommitted);
                }

                return filas > 0;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public Bicicleta ObtenerBicicletaPorSerie(string numeroSerie)
        {
            DataSet ds = null;
            Bicicleta bicicleta = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetBicicletaPorSerie";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@numeroSerie", numeroSerie);

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
                        bicicleta = new Bicicleta();
                        bicicleta.IdBicicleta = Convert.ToInt32(dr["IdBicicleta"]);
                        bicicleta.NumeroSerie = dr["NumeroSerie"].ToString();
                        bicicleta.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                        bicicleta.Marca = dr["Marca"].ToString();
                        bicicleta.Modelo = dr["Modelo"].ToString();
                        bicicleta.Color = dr["Color"].ToString();
                    }
                }
                return bicicleta;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public async Task<Bicicleta> GuardarBicicleta(Bicicleta bicicleta)
        {

            Bicicleta oBicicleta = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GuardarBicicleta";

            cmd.CommandType = CommandType.StoredProcedure;
            double filas = 0;

            try
            {
                cmd.Parameters.Add(new SqlParameter("@numeroSerie", bicicleta.NumeroSerie));
                cmd.Parameters.Add(new SqlParameter("@idCliente", bicicleta.IdCliente));
                cmd.Parameters.Add(new SqlParameter("@marca", bicicleta.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", bicicleta.Modelo));
                cmd.Parameters.Add(new SqlParameter("@color", bicicleta.Color));

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = await db.ExecuteNonQueryAsync(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oBicicleta = bicicleta;

                return oBicicleta;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public async Task<IEnumerable<BicicletaDTO>> ObtenerBicicletas()
        {
            List<BicicletaDTO> lista = new List<BicicletaDTO>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerBicicletas";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    DataTable dt = await db.ExecuteReaderAsync(cmd, "T");

                    foreach (DataRow reader in dt.Rows)
                    {
                        BicicletaDTO bicicleta = new BicicletaDTO();
                        bicicleta.IdBicicleta = Convert.ToInt32(reader["IdBicicleta"]);
                        bicicleta.NumeroSerie = reader["NumeroSerie"].ToString();
                        bicicleta.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                        bicicleta.Marca = reader["Marca"].ToString();
                        bicicleta.Modelo = reader["Modelo"].ToString();
                        bicicleta.Color = reader["Color"].ToString();
                        bicicleta.NombreCliente = reader["NombreCliente"].ToString();


                        lista.Add(bicicleta);
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
    }
}