using ProyectoProgramadolll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
