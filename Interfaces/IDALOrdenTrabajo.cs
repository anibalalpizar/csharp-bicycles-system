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

        OrdenTrabajoDTO ActualizarOrdenTrabajo(OrdenTrabajoDTO orden, List<FotografiaOrden> fotografias);

        Task<bool> EliminarOrdenTrabajo(int idOrdenTrabajo);

        List<OrdenTrabajoDTO> ObtenerOrdenesTrabajo();
        OrdenTrabajoDTO VerificarOrdenPorId(string idOrdenTrabajo);
    }
}
