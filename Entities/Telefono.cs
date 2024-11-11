using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class Telefono
    {
        public int IdTelefono { get; set; }
        public int IdCliente { get; set; }
        public string NumeroTelefonico { get; set; }
    }
}
