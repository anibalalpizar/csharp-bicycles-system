using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities.DTO
{
    public  class VendedorClienteDTO
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public string Contrasegna { get; set; }
        public int IdVendedor { get; set; }
        public string CodigoVendedor { get; set; }
        public int IdRol { get; set; }
        public bool Estado { get; set; }
    }
}
