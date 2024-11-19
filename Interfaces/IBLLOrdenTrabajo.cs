using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLOrdenTrabajo
    {
        OrdenTrabajoDTO GuardarOrdenTrabajo(OrdenTrabajoDTO orden);
    
        Task<bool> EliminarOrdenTrabajo(string idOrdenTrabajo);

        List<OrdenTrabajoDTO> ObtenerOrdenesTrabajo();
        OrdenTrabajoDTO ObtenerOrdenPorId(string idOrdenTrabajo);

    }
}
