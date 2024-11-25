using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class DetalleFacturas
    {
        public int IdDetalleFactura { get; set; }
        public int IdFactura { get; set; }
        public int idOrdenTrabajo { get; set; }
        public decimal MontoColones { get; set; }
        public decimal Venta { get; set; }
    }
}
