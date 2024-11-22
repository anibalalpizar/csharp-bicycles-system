using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities.DTO
{
    public class OrdenTrabajoDTO
    {
        public int IdOrdenTrabajo { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; } = string.Empty;
        public int IdVendedor { get; set; }
        public string NombreVendedor { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public byte[] Firma { get; set; } = Array.Empty<byte>();
        public byte[] ImagenQROrden { get; set; } = Array.Empty<byte>();
        public List<DetalleOrdenTrabajo> ListaDetalles { get; set; } = new List<DetalleOrdenTrabajo>();
        public List<FotografiaOrden> ListaFotografias { get; set; } = new List<FotografiaOrden>();

        public DetalleOrdenTrabajo DetalleOrden { get; set; } = new DetalleOrdenTrabajo();
        public FotografiaOrden FotografiaOrden { get; set; } = new FotografiaOrden();

        public int IdDetalleOrdenTrabajo { get; set; }
        public string NumeroSerie { get; set; }
        public int IdProductoServicio { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int IdFotografia { get; set; }
        public byte[] Fotografia { get; set; } = Array.Empty<byte>();

        public string NombreProducto { get; set; } = string.Empty;
    }
}
