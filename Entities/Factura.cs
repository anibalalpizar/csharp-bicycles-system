using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public int IdPago { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal MontoColones { get; set; }
        public decimal Venta { get; set; }
        public int IdVendedor { get; set; }
        public Pagos Pagos { get; set; }
    }
}
