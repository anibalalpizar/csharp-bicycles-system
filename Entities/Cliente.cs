using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; }

        public int IdTipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Sexo { get; set; }
        public string CorreoElectronico { get; set; }

        public int IdDireccion { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellidos}";
        }
    }
}
