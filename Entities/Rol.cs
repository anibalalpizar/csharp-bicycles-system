using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string DescripcionRol { get; set; }
        public override string ToString() => $"{IdRol}-{DescripcionRol}";
    }
}
