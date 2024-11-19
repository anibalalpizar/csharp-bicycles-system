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
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace ProyectoProgramadolll.DAL
{
    public class DALOrdenTrabajo : IDALOrdenTrabajo
    {

        public OrdenTrabajoDTO ActualizarOrdenTrabajo(OrdenTrabajoDTO orden)
        {
            try
            {
                OrdenTrabajoDTO oOrden = null;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ActualizarOrdenTrabajo";
                cmd.CommandType = CommandType.StoredProcedure;
                int filas = 0;

                string detallesJson = JsonConvert.SerializeObject(orden.ListaDetalles).Trim();
                string fotografiasJson = JsonConvert.SerializeObject(orden.ListaFotografias);


                cmd.Parameters.AddWithValue("@idOrdenTrabajo", orden.IdOrdenTrabajo);
                cmd.Parameters.AddWithValue("@idCliente", orden.IdCliente);
                cmd.Parameters.AddWithValue("@idVendedor", orden.IdVendedor);
                cmd.Parameters.AddWithValue("@fechaInicio", orden.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFinalizacion", orden.FechaFinalizacion);
                cmd.Parameters.AddWithValue("@firma", orden.Firma);
                cmd.Parameters.AddWithValue("@detalles", detallesJson);
                cmd.Parameters.AddWithValue("@fotografias", fotografiasJson);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = (int)db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oOrden = this.ObtenerOrdenPorId(orden.IdOrdenTrabajo.ToString());

                return oOrden;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw ex;
            }
        }

        public Task<bool> EliminarOrdenTrabajo(string idOrdenTrabajo)
        {
            throw new NotImplementedException();
        }

        public OrdenTrabajoDTO GuardarOrdenTrabajo(OrdenTrabajoDTO orden)
        {
            try
            {
                OrdenTrabajoDTO oOrden = null;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_GuardarOrdenTrabajo";
                cmd.CommandType = CommandType.StoredProcedure;
                int filas = 0;

                string detallesJson = JsonConvert.SerializeObject(orden.ListaDetalles).Trim();
                string fotografiasJson = JsonConvert.SerializeObject(orden.ListaFotografias);
                byte[] qrCodeImage = new QuickResponse().GenerarQRCode(orden.IdOrdenTrabajo);


                cmd.Parameters.AddWithValue("@idCliente", orden.IdCliente);
                cmd.Parameters.AddWithValue("@idVendedor", orden.IdVendedor);
                cmd.Parameters.AddWithValue("@fechaInicio", orden.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFinalizacion", orden.FechaFinalizacion);
                cmd.Parameters.AddWithValue("@firma", orden.Firma);
                cmd.Parameters.AddWithValue("@imagenQROrden", qrCodeImage);
                cmd.Parameters.AddWithValue("@detalles", detallesJson);
                cmd.Parameters.AddWithValue("@fotografias", fotografiasJson);

                SqlParameter outputId = new SqlParameter("@idOrdenTrabajo", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputId);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = (int)db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oOrden = this.ObtenerOrdenPorId(orden.IdOrdenTrabajo.ToString());

                int idOrdenTrabajo = (int)outputId.Value;
                this.ActualizarQR(idOrdenTrabajo);

                return oOrden;



            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw ex;
            }
        }

        private void ActualizarQR(int idOrdenTrabajo)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ActualizarQR";
                cmd.CommandType = CommandType.StoredProcedure;

                byte[] qrCodeImage = new QuickResponse().GenerarQRCode(idOrdenTrabajo);

                cmd.Parameters.AddWithValue("@idOrdenTrabajo", idOrdenTrabajo);
                cmd.Parameters.AddWithValue("@imagenQROrden", qrCodeImage);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    db.ExecuteNonQuery(cmd);
                }

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw ex;
            }
        }

        public List<OrdenTrabajoDTO> ObtenerOrdenesTrabajo()
        {
            try
            {
                List<OrdenTrabajoDTO> listaOrdenes = new List<OrdenTrabajoDTO>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ObtenerOrdenesTrabajo";
                cmd.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (IDataReader dr = db.ExecuteReader(cmd))
                    {
                        while (dr.Read())
                        {
                            OrdenTrabajoDTO orden = new OrdenTrabajoDTO
                            {
                                IdOrdenTrabajo = Convert.ToInt32(dr["idOrdenTrabajo"]),
                                IdCliente = Convert.ToInt32(dr["idCliente"]),
                                NombreCliente = Convert.ToString(dr["nombreCliente"]),
                                IdVendedor = Convert.ToInt32(dr["idVendedor"]),
                                NombreVendedor = Convert.ToString(dr["nombreVendedor"]),
                                FechaInicio = Convert.ToDateTime(dr["fechaInicio"]),
                                FechaFinalizacion = Convert.ToDateTime(dr["fechaFinalizacion"]),
                                Firma = (byte[])dr["firma"],
                                ImagenQROrden = (byte[])dr["imagenQROrden"]
                            };
                            listaOrdenes.Add(orden);
                        }
                    }
                }

                return listaOrdenes;

            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw ex;
            }
        }

        public OrdenTrabajoDTO ObtenerOrdenPorId(string idOrdenTrabajo)
        {
            DataSet ds = null;
            OrdenTrabajoDTO orden = null;
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "sp_ObtenerOrdenPorId",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@idOrdenTrabajo", idOrdenTrabajo);

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(cmd, "T");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Inicializar OrdenTrabajoDTO
                    orden = new OrdenTrabajoDTO();
                    DataRow dr = ds.Tables[0].Rows[0];

                    // Asignar datos principales de la orden
                    orden.IdOrdenTrabajo = Convert.ToInt32(dr["idOrdenTrabajo"]);
                    orden.IdCliente = Convert.ToInt32(dr["idCliente"]);
                    orden.IdVendedor = Convert.ToInt32(dr["idVendedor"]);
                    orden.FechaInicio = Convert.ToDateTime(dr["fechaInicio"]);
                    orden.FechaFinalizacion = Convert.ToDateTime(dr["fechaFinalizacion"]);
                    orden.Firma = dr["firma"] as byte[];
                    orden.ImagenQROrden = dr["imagenQROrden"] as byte[];


                    orden.ListaDetalles = ds.Tables[0].AsEnumerable()
                        .Where(row => row["idDetalleOrdenTrabajo"] != DBNull.Value)
                        .Select(row => new DetalleOrdenTrabajo
                        {
                            IdDetalleOrdenTrabajo = Convert.ToInt32(row["idDetalleOrdenTrabajo"]),
                            IdOrdenTrabajo = Convert.ToInt32(row["idOrdenTrabajo"]),
                            NumeroSerie = Convert.ToString(row["numeroSerie"]),
                            IdProductoServicio = Convert.ToInt32(row["idProductoServicio"]),
                            Descripcion = Convert.ToString(row["descripcion"])
                        }).ToList();


                    orden.ListaFotografias = ds.Tables[0].AsEnumerable()
                        .Where(row => row["idFotografia"] != DBNull.Value)
                        .Select(row => new FotografiaOrden
                        {
                            IdFotografiaOrden = Convert.ToInt32(row["idFotografia"]),
                            IdOrdenTrabajo = Convert.ToInt32(row["idOrdenTrabajo"]),
                            Fotografia = row["fotografia"] as byte[]
                        }).ToList();
                }

                return orden;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw new Exception("Error al obtener la orden de trabajo", ex);
            }
        }

    }
}
