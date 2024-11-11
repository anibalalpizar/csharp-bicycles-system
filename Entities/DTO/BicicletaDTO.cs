using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities.DTO
{
    public class BicicletaDTO
    {
        public int IdBicicleta { get; set; }
        public string NumeroSerie { get; set; }
        public int IdCliente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string NombreCliente { get; set; }
    }
}
