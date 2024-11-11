using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class TipoIdentificacion
    {
        public int IdTipoIdentificacion { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
