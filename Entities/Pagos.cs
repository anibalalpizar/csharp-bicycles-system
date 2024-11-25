using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public string TipoTarjeta { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPago { get; set; }
    }
}
