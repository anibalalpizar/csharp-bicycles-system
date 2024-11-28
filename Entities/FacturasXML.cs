using System;
using System.Xml;

namespace ProyectoProgramadolll.Entities
{
    public class FacturasXML
    {
        public int IdFacturaXML { get; set; }
        public int IdFactura { get; set; }
        public XmlDocument XML { get; set; }
        public DateTime FechaEnvio { get; set; }
    }
}
