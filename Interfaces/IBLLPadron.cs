using ProyectoProgramadolll.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLPadron
    {
        PadronDTO GetPersonaById(string IdCliente);
    }
}
