using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    public class Tienda
    {
        public int IdTienda { get; set; }
        public int CedulaJuridica { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public decimal ImpuestoVenta { get; set; }
        public override string ToString() =>

      $"{IdTienda} {CedulaJuridica} {Nombre} {Telefono} {Direccion} {ImpuestoVenta}";

    }


}
