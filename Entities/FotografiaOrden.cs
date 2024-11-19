using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class FotografiaOrden
    {
        public int IdFotografiaOrden { get; set; }
        public int IdOrdenTrabajo { get; set; }
        public byte[] Fotografia { get; set; }
    }
}
