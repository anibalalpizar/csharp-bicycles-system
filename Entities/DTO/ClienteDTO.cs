using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities.DTO
{
    public class ClienteDTO
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string TipoIdentificacionDescripcion { get; set; }
        public string Nombre { get; set; }
        public bool Sexo { get; set; }
        public string Genero { get; set; }
        public string CorreoElectronico { get; set; }
        public int IdDireccion { get; set; }
        public string DireccionCompleta { get; set; }
        public string Telefonos { get; set; }
        public List<Telefono> ListaTelefonos { get; set; }

        public Direccion Direccion { get; set; }


    }
}
