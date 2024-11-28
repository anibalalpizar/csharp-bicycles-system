using System;
using System.Collections.Generic;


namespace ProyectoProgramadolll.Entities
{
    public class OrdenTrabajo
    {
        public int IdOrdenTrabajo { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public byte[] Firma { get; set; }
        public byte[] ImagenQROrden { get; set; }

        public List<DetalleOrdenTrabajo> DetalleOrdenes { get; set; } = new List<DetalleOrdenTrabajo>();
        public List<FotografiaOrden> FotografiaOrdenes { get; set; } = new List<FotografiaOrden>();
    }
}
