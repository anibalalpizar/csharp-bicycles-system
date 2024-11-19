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
    public class DALProductoServicio : IDALProductoServicio
    {
        public ProductoServicio ActualizarProductoServicio(ProductoServicio productoServicio)
        {
            ProductoServicio oProductoServicio = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ActualizarProductoServicio";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            double filas = 0;

            try
            {
                cmd.Parameters.AddWithValue("@codigoProductoServicio", productoServicio.CodigoProductoServicio);
                cmd.Parameters.AddWithValue("@idTienda", productoServicio.IdTienda);
                cmd.Parameters.AddWithValue("@descripcion", productoServicio.Descripcion);
                cmd.Parameters.AddWithValue("@cantidadInventario", productoServicio.CantidadInventario);
                cmd.Parameters.AddWithValue("@precioColones", productoServicio.PrecioColones);
                cmd.Parameters.AddWithValue("@venta", productoServicio.Venta);
                cmd.Parameters.AddWithValue("@estado", productoServicio.Estado);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oProductoServicio = this.ObtenerProductoServicioPorId(productoServicio.CodigoProductoServicio);

                return oProductoServicio;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public async Task<bool> EliminarProductoServicio(string codigoProductoServicio)
        {
            bool eliminado = false;
            double filas = 0d;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_EliminarProductoServicio";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoProductoServicio", codigoProductoServicio);

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
                return false;
            }
        }

        public ProductoServicio GuardarProductoServicio(ProductoServicio productoServicio)
        {
            ProductoServicio oProductoServicio = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GuardarProductoServicio";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            double filas = 0;

            try
            {
                cmd.Parameters.AddWithValue("@codigoProductoServicio", productoServicio.CodigoProductoServicio);
                cmd.Parameters.AddWithValue("@idTienda", productoServicio.IdTienda);
                cmd.Parameters.AddWithValue("@descripcion", productoServicio.Descripcion);
                cmd.Parameters.AddWithValue("@cantidadInventario", productoServicio.CantidadInventario);
                cmd.Parameters.AddWithValue("@precioColones", productoServicio.PrecioColones);
                cmd.Parameters.AddWithValue("@venta", productoServicio.Venta);
                cmd.Parameters.AddWithValue("@estado", productoServicio.Estado);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oProductoServicio = productoServicio;

                return oProductoServicio;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }
        }

        public ProductoServicio ObtenerProductoServicioPorId(string codigoProductoServicio)
        {
            DataSet ds = null;
            ProductoServicio oProductoServicio = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerProductoServicioPorId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigoProductoServicio", codigoProductoServicio);

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

                        oProductoServicio = new ProductoServicio();
                        oProductoServicio.IdProductoServicio = int.Parse(dr["IdProductoServicio"].ToString());
                        oProductoServicio.CodigoProductoServicio = dr["CodigoProductoServicio"].ToString();
                        oProductoServicio.IdTienda = int.Parse(dr["IdTienda"].ToString());
                        oProductoServicio.Descripcion = dr["Descripcion"].ToString();
                        oProductoServicio.CantidadInventario = int.Parse(dr["CantidadInventario"].ToString());
                        oProductoServicio.PrecioColones = decimal.Parse(dr["PrecioColones"].ToString());
                        oProductoServicio.Venta = decimal.Parse(dr["Venta"].ToString());
                        oProductoServicio.Estado = dr["Estado"] != DBNull.Value && (dr["Estado"].ToString() == "1" || dr["Estado"].ToString().ToLower() == "true");

                    }
                }
                return oProductoServicio;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;

            }
        }

        public IEnumerable<ProductoServicioDTO> ObtenerProductoServicios()
        {
            IDataReader reader = null;
            IList<ProductoServicioDTO> listaProductoServicio = new List<ProductoServicioDTO>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ObtenerProductosServicios";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(cmd);

                    while(reader.Read()) {
                    
                        ProductoServicioDTO oProductoServicioDTO = new ProductoServicioDTO();
                        oProductoServicioDTO.IdProductoServicio = reader.GetInt32(reader.GetOrdinal("IdProductoServicio"));
                        oProductoServicioDTO.CodigoProductoServicio = reader.GetString(reader.GetOrdinal("CodigoProductoServicio"));
                        oProductoServicioDTO.IdTienda = reader.GetInt32(reader.GetOrdinal("IdTienda"));
                        oProductoServicioDTO.DescripcionTienda = reader.GetString(reader.GetOrdinal("DescripcionTienda"));
                        oProductoServicioDTO.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));  
                        oProductoServicioDTO.CantidadInventario = reader.GetInt32(reader.GetOrdinal("CantidadInventario"));
                        oProductoServicioDTO.PrecioColones = reader.GetDecimal(reader.GetOrdinal("PrecioColones"));
                        oProductoServicioDTO.Venta = reader.GetDecimal(reader.GetOrdinal("Venta"));
                        oProductoServicioDTO.DescripcionEstado = reader.GetString(reader.GetOrdinal("EstadoDescripcion"));

                        listaProductoServicio.Add(oProductoServicioDTO);
                    }
                }
                return listaProductoServicio;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw;
            }


        }
    }
}
