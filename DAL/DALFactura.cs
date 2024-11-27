using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using ProyectoProgramadolll.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProyectoProgramadolll.DAL
{
    public class DALFactura : IDALFactura
    {
        public FacturaDTO GuardarFactura(FacturaDTO factura, List<decimal> montoIndividualC, List<decimal> montoIndividualD)
        {
            try
            {
                FacturaDTO oFactura = null;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_GuardarFactura";
                cmd.CommandType = CommandType.StoredProcedure;
                int filas = 0;

                for (int i = 0; i < factura.ListaDetallesFactura.Count; i++)
                {
                    if (i < montoIndividualC.Count && i < montoIndividualD.Count)
                    {
                        factura.ListaDetallesFactura[i].MontoColones = montoIndividualC[i];
                        factura.ListaDetallesFactura[i].Venta = montoIndividualD[i];
                    }
                    else
                    {
                        throw new ArgumentException("Los valores de montoIndividualC y montoIndividualD no coinciden con el número de detalles de la factura.");
                    }
                }


                string detallesJson = JsonConvert.SerializeObject(factura.ListaDetallesFactura).Trim();

                cmd.Parameters.AddWithValue("@idCliente", factura.IdCliente);
                cmd.Parameters.AddWithValue("@fechaFactura", factura.FechaFactura);
                cmd.Parameters.AddWithValue("@montoColones", factura.MontoColones);
                cmd.Parameters.AddWithValue("@venta", factura.Venta);
                cmd.Parameters.AddWithValue("@idVendedor", factura.IdVendedor);
                cmd.Parameters.AddWithValue("@tipoTarjeta", factura.TipoTarjeta);
                cmd.Parameters.AddWithValue("@numeroTarjeta", factura.NumeroTarjeta);
                cmd.Parameters.AddWithValue("@fechaPago", factura.FechaPago);
                cmd.Parameters.AddWithValue("@montoPago", factura.MontoPago);
                cmd.Parameters.AddWithValue("@detalles", detallesJson);

                using(IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    filas = (int)db.ExecuteNonQuery(cmd, IsolationLevel.ReadCommitted);
                }

                if (filas > 0)
                    oFactura = this.ObtenerFacturaPorId(factura.IdFactura);

                return oFactura;

            }
            catch (Exception ex)
            {
               Log.LogException(ex);
                throw ex;
            }
        }

        public FacturaDTO ObtenerFacturaPorId(int idFactura)
        {
            try
            {
                FacturaDTO oFactura = null;
                DataSet ds = null;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ObtenerFacturaPorId";
                cmd.CommandType = CommandType.StoredProcedure;

              
                cmd.Parameters.AddWithValue("@idFactura", idFactura);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(cmd, "T");

                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        DataRow fila = ds.Tables[0].Rows[0];

                        oFactura = new FacturaDTO
                        {
                            IdFactura = Convert.ToInt32(fila["idFactura"]),
                            IdCliente = Convert.ToInt32(fila["idCliente"]),
                            NombreCliente = fila["nombreCliente"].ToString(),
                            FechaFactura = Convert.ToDateTime(fila["fechaFactura"]),
                            MontoColones = Convert.ToDecimal(fila["montoColones"]),
                            Venta = Convert.ToDecimal(fila["venta"]),
                            IdVendedor = Convert.ToInt32(fila["idVendedor"]),
                            NombreVendedor = fila["nombreVendedor"].ToString(),
                            TipoTarjeta = fila["tipoTarjeta"].ToString(),
                            NumeroTarjeta = fila["numeroTarjeta"].ToString(),
                            FechaPago = Convert.ToDateTime(fila["fechaPago"]),
                            MontoPago = Convert.ToDecimal(fila["montoPago"]),
                            ListaDetallesFactura = new List<FacturaDTO>()
                        };

                       
                        foreach (DataRow detalleFila in ds.Tables[0].Rows)
                        {
           
                            if (Convert.ToInt32(detalleFila["idFactura"]) == idFactura)
                            {
                                FacturaDTO detalle = new FacturaDTO
                                {
                                    IdDetalleFactura = Convert.ToInt32(detalleFila["idDetalleFactura"]),
                                    IdOrdenTrabajo = Convert.ToInt32(detalleFila["idOrdenTrabajo"]),
                                    MontoColones = Convert.ToDecimal(detalleFila["montoColones"]),
                                    Venta = Convert.ToDecimal(detalleFila["venta"]),
                                    IdDetalleOrdenTrabajo = Convert.ToInt32(detalleFila["idDetalleOrdenTrabajo"]),
                                    NumeroSerie = detalleFila["numeroSerie"].ToString(),
                                    IdProductoServicio = Convert.ToInt32(detalleFila["idProductoServicio"]),
                                    DescripcionDetalle = detalleFila["descripcionDetalle"].ToString(),
                                    NombreProducto = detalleFila["nombreProducto"].ToString()
                                };
                                oFactura.ListaDetallesFactura.Add(detalle);
                            }
                        }
                    }
                }

                return oFactura;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                throw ex;
            }
        }



        public List<FacturaDTO> ObtenerFacturas()
        {
            throw new NotImplementedException();
        }
    }
}
