using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.BLL
{
    class ProvinciaBLL : IProvinciaService
    {
        private readonly IProvinciaService _provinciaService;

        public ProvinciaBLL(IProvinciaService provinciaService)
        {
            _provinciaService = provinciaService;
        }

        public async Task<List<Provincia>> ObtenerProvincias()
        {
            return await _provinciaService.ObtenerProvincias();
        }
       

        public async Task<List<Canton>> ObtenerCantones()
        {
            return await _provinciaService.ObtenerCantones();
        }

        public async Task<List<Distrito>> ObtenerDistritos()
        {
            return await _provinciaService.ObtenerDistritos();
        }

    }
}