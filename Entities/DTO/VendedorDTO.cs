using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities.DTO
{
    public class VendedorDTO
    {
        public int IdVendedor { get; set; }
        public string CodigoVendedor { get; set; }
        public string RolDescripcion { get; set; }
        public int IdRol { get; set; }
        public string Contrasegna { get; set; }
        public int IdTienda { get; set; }
        public string NombreTienda { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte[] Fotografia { get; set; }
        public bool Estado { get; set; }
        public string EstadoDescripcion { get; set; }
    }
}
