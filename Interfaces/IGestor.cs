using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoProgramadolll.Entities.DTO;

namespace ProyectoProgramadolll.Interfaces
{
    interface IGestor
    {
        string ObtenerXML(FacturaDTO factura);
    }
}
