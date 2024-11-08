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
    public class DALTienda : IDALTienda
    {
        public async Task<Tienda> ActualizarTienda(Tienda tienda)
        {
            Tienda oTienda = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ActualizarTienda";
            cmd.CommandType = CommandType.StoredProcedure;
            int filas = 0;

            try
            {
                cmd.Parameters.AddWithValue("@cedulaJuridica", tienda.CedulaJuridica);
                cmd.Parameters.AddWithValue("@nombre", tienda.Nombre);
                cmd.Parameters.AddWithValue("@telefono", tienda.Telefono);
                cmd.Parameters.AddWithValue("@direccion", tienda.Direccion);
                cmd.Parameters.AddWithValue("@impuestoVenta", tienda.ImpuestoVenta);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = await db.ExecuteNonQueryAsync(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oTienda = this.ObtenerTiendaPorId(tienda.CedulaJuridica.ToString());

                return oTienda;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la tienda", ex);
            }

        }

        public async Task<bool> EliminarTienda(string idTienda)
        {
            bool eliminado = false;
            double filas = 0d;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_EliminarTienda";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cedulaJuridica", idTienda);

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
                throw new Exception("Error al eliminar la tienda", ex);
            }
        }

        public async Task<Tienda> GuardarTienda(Tienda tienda)
        {
            Tienda oTienda = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GuardarTienda";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@cedulaJuridica", tienda.CedulaJuridica);
                cmd.Parameters.AddWithValue("@nombre", tienda.Nombre);
                cmd.Parameters.AddWithValue("@telefono", tienda.Telefono);
                cmd.Parameters.AddWithValue("@direccion", tienda.Direccion);
                cmd.Parameters.AddWithValue("@impuestoVenta", tienda.ImpuestoVenta);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var filas = await db.ExecuteNonQueryAsync(cmd, IsolationLevel.ReadCommitted);

                }
                return oTienda;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la tienda", ex);
            }
        }

        public Tienda ObtenerTiendaPorId(string idTienda)
        {
            DataSet ds = null;
            Tienda oTienda = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerTiendaPorId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cedulaJuridica", idTienda);

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

                        oTienda = new Tienda();
                        oTienda.CedulaJuridica = int.Parse(dr["CedulaJuridica"].ToString());
                        oTienda.Nombre = dr["Nombre"].ToString();
                        oTienda.Telefono = int.Parse(dr["Telefono"].ToString());
                        oTienda.Direccion = dr["Direccion"].ToString();
                        oTienda.ImpuestoVenta = decimal.Parse(dr["ImpuestoVenta"].ToString());

                    }
                }
                return oTienda;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la tienda", ex);
            }

        }

        public async Task<IEnumerable<Tienda>> ObtenerTodasLasTiendas()
        {
            List<Tienda> listaTienda = new List<Tienda>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerTodasLasTiendas";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    DataTable dt = await db.ExecuteReaderAsync(cmd, "T");
                    foreach (DataRow dr in dt.Rows)
                    {
                        Tienda oTienda = new Tienda();
                        oTienda.IdTienda = int.Parse(dr["IdTienda"].ToString());
                        oTienda.CedulaJuridica = int.Parse(dr["CedulaJuridica"].ToString());
                        oTienda.Nombre = dr["Nombre"].ToString();
                        oTienda.Telefono = int.Parse(dr["Telefono"].ToString());
                        oTienda.Direccion = dr["Direccion"].ToString();
                        oTienda.ImpuestoVenta = decimal.Parse(dr["ImpuestoVenta"].ToString());
                        listaTienda.Add(oTienda);
                    }
                }
                return listaTienda;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la tienda", ex);
            }
        }
    }
}
