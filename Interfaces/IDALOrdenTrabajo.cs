using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Entities;
using System.Collections.Generic;
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
        Task<IEnumerable<OrdenTrabajoDTO>> ObtenerOrdenPorIdCliente(string idCliente);

        Task<IEnumerable<OrdenTrabajoDTO>> ObtenerPrecioProductoPorIdOrden(string idOrdenTrabajo);
    }
}
