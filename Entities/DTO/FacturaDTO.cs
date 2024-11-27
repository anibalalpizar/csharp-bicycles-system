using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProyectoProgramadolll.Entities.DTO
{
    public class FacturaDTO
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public string nombreCliente { get; set; }
        public int IdPago { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal MontoColones { get; set; }
        public decimal Venta { get; set; }
        public int IdVendedor { get; set; }
        public string nombreVendedor { get; set; }
        public Pagos Pagos { get; set; }

        //Detalles de la factura
        public List<FacturaDTO> ListaDetallesFactura { get; set; } = new List<FacturaDTO>();
        public int IdDetalleFactura { get; set; }
        public int IdOrdenTrabajo { get; set; }

        //Factura XML
        public int IdFacturaXML { get; set; }
        public XmlDocument XML { get; set; }
        public DateTime FechaEnvio { get; set; }

        //Pagos
        public string TipoTarjeta { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPago { get; set; }

        //Extras
        public string NombreCliente { get; set; }
        public string NombreVendedor { get; set; }
        public string NumeroSerie { get; set; }
        public string NombreProducto { get; set; }
        public int  IdProductoServicio { get; set; }
        public int IdDetalleOrdenTrabajo { get; set; }
        public string DescripcionDetalle { get; set; }



    }
}
