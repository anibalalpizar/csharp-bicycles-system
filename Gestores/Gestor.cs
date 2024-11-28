using System;
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

                XmlElement pagos = documento.CreateElement("Pagos");
                pagos.InnerText = factura.IdPago.ToString(); ;
                raiz.AppendChild(pagos);

                XmlElement fechaPago = documento.CreateElement("FechaPago");
                fechaPago.InnerText = factura.FechaPago.ToString("yyyy-MM-dd HH:mm:ss");
                raiz.AppendChild(fechaPago);

                XmlElement numeroTarjeta = documento.CreateElement("NumeroTarjeta");
                numeroTarjeta.InnerText = factura.NumeroTarjeta;
                raiz.AppendChild(numeroTarjeta);

                XmlElement tipoTarjeta = documento.CreateElement("TipoTarjeta");
                tipoTarjeta.InnerText = factura.TipoTarjeta;
                raiz.AppendChild(tipoTarjeta);

                XmlElement montoColones = documento.CreateElement("MontoColones");
                montoColones.InnerText = factura.MontoColones.ToString("F2");
                raiz.AppendChild(montoColones);

                XmlElement venta = documento.CreateElement("Venta");
                venta.InnerText = factura.Venta.ToString("F2");
                raiz.AppendChild(venta);

                XmlElement detallesFactura = documento.CreateElement("DetallesFactura");
                foreach (var detalle in factura.ListaDetallesFactura)
                {
                    XmlElement detalleFactura = documento.CreateElement("DetalleFactura");

                    XmlElement ordenId = documento.CreateElement("IdOrdenTrabajo");
                    ordenId.InnerText = detalle.IdOrdenTrabajo.ToString();
                    detalleFactura.AppendChild(ordenId);

                    XmlElement bicicleta = documento.CreateElement("NumeroSerie");
                    bicicleta.InnerText = detalle.NumeroSerie.ToString();
                    detalleFactura.AppendChild(bicicleta);

                    XmlElement descripcionDetalle = documento.CreateElement("DescripcionDetalle");
                    descripcionDetalle.InnerText = detalle.DescripcionDetalle;
                    detalleFactura.AppendChild(descripcionDetalle);

               
                    XmlElement precioColones = documento.CreateElement("PrecioProducto");
                    precioColones.InnerText = detalle.PrecioProducto.ToString("F2");
                    detalleFactura.AppendChild(precioColones);


                    XmlElement precioDolares = documento.CreateElement("PrecioDolarProducto");
                    precioDolares.InnerText = detalle.PrecioDolarProducto.ToString("F2");
                    detalleFactura.AppendChild(precioDolares);

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
