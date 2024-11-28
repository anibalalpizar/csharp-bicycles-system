using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    public interface IBLLOrdenTrabajo
    {
        OrdenTrabajoDTO GuardarOrdenTrabajo(OrdenTrabajoDTO orden, List<FotografiaOrden> fotografias);
    
        Task<bool> EliminarOrdenTrabajo(int idOrdenTrabajo);

        List<OrdenTrabajoDTO> ObtenerOrdenesTrabajo();
        OrdenTrabajoDTO ObtenerOrdenPorId(string idOrdenTrabajo);
        Task<IEnumerable<OrdenTrabajoDTO>> ObtenerOrdenPorIdCliente(string idCliente);
        Task<IEnumerable<OrdenTrabajoDTO>> ObtenerPrecioProductoPorIdOrden(string idOrdenTrabajo);

    }
}
