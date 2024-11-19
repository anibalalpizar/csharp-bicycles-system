using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IDALOrdenTrabajo
    {
        OrdenTrabajoDTO GuardarOrdenTrabajo(OrdenTrabajoDTO orden);
        OrdenTrabajoDTO ObtenerOrdenPorId(string idOrdenTrabajo);

        OrdenTrabajoDTO ActualizarOrdenTrabajo(OrdenTrabajoDTO orden);

        Task<bool> EliminarOrdenTrabajo(string idOrdenTrabajo);

        List<OrdenTrabajoDTO> ObtenerOrdenesTrabajo();
    }
}
