using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;

namespace ProyectoProgramadolll.Gestores
{
    class Gestor : IGestor
    {
        public string ObtenerXML(FacturaDTO factura)
        {
            try
            {
                XmlDocument documento = new XmlDocument();

                XmlDeclaration dec = documento.CreateXmlDeclaration("1.0", "utf-8", null);
                documento.AppendChild(dec);

                XmlProcessingInstruction xslt = documento.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"Factura.xslt\"");
                documento.AppendChild(xslt);

                XmlElement raiz = documento.CreateElement("Factura");
                documento.AppendChild(raiz);

                XmlElement idFactura = documento.CreateElement("IdFactura");
                idFactura.InnerText = factura.IdFactura.ToString();
                raiz.AppendChild(idFactura);

                XmlElement fechaFactura = documento.CreateElement("FechaFactura");
                fechaFactura.InnerText = factura.FechaFactura.ToString("yyyy-MM-dd HH:mm:ss");
                raiz.AppendChild(fechaFactura);

                XmlElement fechaEnvio = documento.CreateElement("FechaEnvio");
                fechaEnvio.InnerText = factura.FechaEnvio.ToString("yyyy-MM-dd HH:mm:ss");
                raiz.AppendChild(fechaEnvio);

                XmlElement fechaPago = documento.CreateElement("FechaPago");
                fechaPago.InnerText = factura.FechaPago.ToString("yyyy-MM-dd HH:mm:ss");
                raiz.AppendChild(fechaPago);

                XmlElement cliente = documento.CreateElement("Cliente");
                cliente.InnerText = factura.NombreCliente;
                raiz.AppendChild(cliente);

                XmlElement idCliente = documento.CreateElement("IdCliente");
                idCliente.InnerText = factura.IdCliente.ToString();
                raiz.AppendChild(idCliente);

                XmlElement vendedor = documento.CreateElement("Vendedor");
                vendedor.InnerText = factura.NombreVendedor;
                raiz.AppendChild(vendedor);

                XmlElement idVendedor = documento.CreateElement("IdVendedor");
                idVendedor.InnerText = factura.IdVendedor.ToString();
                raiz.AppendChild(idVendedor);

                XmlElement numeroTarjeta = documento.CreateElement("NumeroTarjeta");
                numeroTarjeta.InnerText = factura.NumeroTarjeta;
                raiz.AppendChild(numeroTarjeta);

                XmlElement tipoTarjeta = documento.CreateElement("TipoTarjeta");
                tipoTarjeta.InnerText = factura.TipoTarjeta;
                raiz.AppendChild(tipoTarjeta);

                XmlElement detallesFactura = documento.CreateElement("DetallesFactura");
                foreach (var detalle in factura.ListaDetallesFactura)
                {
                    XmlElement detalleFactura = documento.CreateElement("DetalleFactura");

                    XmlElement descripcionDetalle = documento.CreateElement("DescripcionDetalle");
                    descripcionDetalle.InnerText = detalle.DescripcionDetalle;
                    detalleFactura.AppendChild(descripcionDetalle);

                    XmlElement montoColones = documento.CreateElement("MontoColones");
                    montoColones.InnerText = detalle.MontoColones.ToString("F2");
                    detalleFactura.AppendChild(montoColones);

                    XmlElement fechaDetalleFactura = documento.CreateElement("FechaFactura");
                    fechaDetalleFactura.InnerText = detalle.FechaFactura.ToString("yyyy-MM-dd HH:mm:ss");
                    detalleFactura.AppendChild(fechaDetalleFactura);

                    XmlElement fechaEnvioDetalle = documento.CreateElement("FechaEnvio");
                    fechaEnvioDetalle.InnerText = detalle.FechaEnvio.ToString("yyyy-MM-dd HH:mm:ss");
                    detalleFactura.AppendChild(fechaEnvioDetalle);

                    XmlElement fechaPagoDetalle = documento.CreateElement("FechaPago");
                    fechaPagoDetalle.InnerText = detalle.FechaPago.ToString("yyyy-MM-dd HH:mm:ss");
                    detalleFactura.AppendChild(fechaPagoDetalle);

                    detallesFactura.AppendChild(detalleFactura);
                }
                raiz.AppendChild(detallesFactura);

                return documento.OuterXml;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el XML: " + ex.Message);
            }
        }

    }
}
