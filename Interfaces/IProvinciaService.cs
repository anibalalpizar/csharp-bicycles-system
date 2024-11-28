using ProyectoProgramadolll.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Interfaces
{
    interface IProvinciaService
    {
        Task<List<Provincia>> ObtenerProvincias();
        Task<List<Canton>> ObtenerCantones();
        Task<List<Distrito>> ObtenerDistritos();

    }
}
